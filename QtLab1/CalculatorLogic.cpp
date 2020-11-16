#include "CalculatorLogic.h"

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{
    trenutnaVrednost = 0.0;
    vrednost = 0.0;
    sabiranje = false;
    oduzimanje = false;
    mnozenje = false;
    deljenje = false;
    jednako = false;
    korenovanje = false;
    promenaZnaka = false;
    brisanjeCifre = false;
    brisanje = false;
    tacka = false;
    sabZaJednako = false;
    oduZaJednako = false;
    mnoZaJednako = false;
    delZaJednako = false;
}

void CalculatorLogic::doCommand(QString btn)
{
    if (btn.compare("+") == 0)
    {
        sabiranje = true;
    }
    else if (btn.compare("-") == 0)
    {
        oduzimanje = true;
    }
    else if (btn.compare("*") == 0)
    {
        mnozenje = true;

    }
    else if (btn.compare("/") == 0)
    {
        deljenje = true;
    }
    else if (btn.compare("=") == 0)
    {
        jednako = true;
    }
    else if (btn.compare("√") == 0)
    {
        korenovanje = true;
    }
    else if (btn.compare("±") == 0)
    {
        promenaZnaka = true;
    }
    else if (btn.compare("←") == 0)
    {
        brisanjeCifre = true;
    }
    else if (btn.compare(".") == 0)
    {
        tacka = true;
    }
    else if (btn.compare("C") == 0)
    {
        brisanje = true;
    }
    else //broj
    {
        trenutnaVrednost = btn.toDouble();
    }

    if (!sabiranje && !oduzimanje && !mnozenje && !deljenje && !jednako
            && !korenovanje && !brisanje && !brisanjeCifre
            && !promenaZnaka && !tacka)
    {
        if (vrednost == 0.0 || vrednost == 0 || rezultat.compare("nan") == 0)
        {
            rezultat = QString::number(trenutnaVrednost);
            vrednost = rezultat.toDouble();
        }
        else
        {
            QString novaVrednost = rezultat + QString::number(trenutnaVrednost);
            rezultat = novaVrednost;
            vrednost = rezultat.toDouble();
        }
    }
    else if (sabiranje || oduzimanje || mnozenje || deljenje) //neka od binarnih operacija
    {
        zaOperacije = vrednost;
        if (sabiranje)
        {
            zaIstoriju = rezultat + " + ";
            sabiranje = false;
            sabZaJednako = true;
        }
        else if (oduzimanje)
        {
            zaIstoriju = rezultat + " - ";
            oduzimanje = false;
            oduZaJednako = true;
        }
        else if (mnozenje)
        {
            zaIstoriju = rezultat + " * ";
            mnozenje = false;
            mnoZaJednako = true;
        }
        else
        {
            zaIstoriju = rezultat + " / ";
            deljenje = false;
            delZaJednako = true;
        }
        rezultat = "";
    }
    else if (jednako)
    {
        zaIstoriju += QString::number(vrednost);
        if (sabZaJednako)
        {
            sabZaJednako = false;
            jednako = false;
            zaIstoriju += " = ";
            double novaVred = zaOperacije + vrednost;
            vrednost = novaVred;
            rezultat = QString::number(novaVred);
            zaIstoriju += QString::number(novaVred);
        }
        else if (oduZaJednako)
        {
            oduZaJednako = false;
            jednako = false;
            zaIstoriju += " = ";
            double novaVred = zaOperacije - vrednost;
            vrednost = novaVred;
            rezultat = QString::number(novaVred);
            zaIstoriju += QString::number(novaVred);
        }
        else if (mnoZaJednako)
        {
            mnoZaJednako = false;
            jednako = false;
            zaIstoriju += " = ";
            double novaVred = zaOperacije * vrednost;
            vrednost = novaVred;
            rezultat = QString::number(novaVred);
            zaIstoriju += QString::number(novaVred);
        }
        else if (delZaJednako)
        {
            delZaJednako = false;
            jednako = false;
            zaIstoriju += " = ";
            if (vrednost != 0 || vrednost != 0.0)
            {
                double novaVred = zaOperacije / vrednost;
                vrednost = novaVred;
                rezultat = QString::number(novaVred);
                zaIstoriju += QString::number(novaVred);
            }
            else
            {
                rezultat = "NAN";
                zaIstoriju += rezultat;
            }
        }
        //updatuje se i istorija
        emit resultHistoryChanged(rezultat);
    }
    else if (korenovanje)
    {
       korenovanje = false;
       zaIstoriju = "√" + QString::number(vrednost);
       double novaVred = qSqrt(vrednost);
       //ukoliko je koren iz negativnog broja funkcija vraca NAN
       vrednost = novaVred;
       rezultat = QString::number(vrednost);
       zaIstoriju += " = " + QString::number(novaVred);
       //updatuje se i istorija
       emit resultHistoryChanged(rezultat);
    }
    else if (promenaZnaka)
    {
        promenaZnaka = false;
        double novaVred = (-1)* vrednost;
        vrednost = novaVred;
        rezultat = QString::number(vrednost);
        zaIstoriju = "±" + QString::number(novaVred);
        //updatuje se i istorija
        emit resultHistoryChanged(rezultat);
    }
    else if (brisanje)
    {
        brisanje = false;
        vrednost = 0.0;
        rezultat = QString::number(vrednost);
    }
    else if (brisanjeCifre)
    {
        brisanjeCifre = false;
        if (vrednost != 0.0 || vrednost != 0)
        {
            QString novaVred = rezultat;
            novaVred.chop(1);
            if (novaVred.compare("") == 0)
            {
                vrednost = 0;
                rezultat = QString::number(vrednost);
            }
            else
            {
                rezultat = novaVred;
                vrednost = novaVred.toDouble();
            }
        }
        //ukoliko je vrednost = 0 nema koja cifra da se obrise
    }
    else //ako nije nista od prethodnog onda je tacka
    {
        tacka = false;
        if (!rezultat.contains("."))
        {
            QString novaVred = QString::number(vrednost)+".";
            vrednost = novaVred.toDouble();
            rezultat = novaVred;
        }
    }
    emit resultChanged(rezultat);
}
