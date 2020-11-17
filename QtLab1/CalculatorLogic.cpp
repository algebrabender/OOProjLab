#include "CalculatorLogic.h"

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{
    trenutnaVrednost = 0.0;
    vrednost = 0.0;
    zaIstoriju = "0";
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
    jednakoPoslednje = false;
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

    //logika
    if (!sabiranje && !oduzimanje && !mnozenje && !deljenje && !jednako
            && !korenovanje && !brisanje && !brisanjeCifre
            && !promenaZnaka && !tacka)
    {

        if (vrednost == 0 || rezultat.compare("nan") == 0 || jednakoPoslednje)
        {
            if (zaIstoriju.compare("0") == 0)
                            zaIstoriju = "";
            if (jednakoPoslednje) //posle = sledi novi broj
            {
                rezultat = QString::number(trenutnaVrednost);
                jednakoPoslednje = false;
            }
            if(rezultat.contains(".")) //ako je prva nula pa tacka
                rezultat += QString::number(trenutnaVrednost);
            else
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
    //potencijalno kod moze da se optimizuje
    else
    {
        if (sabZaJednako || oduZaJednako || mnoZaJednako || delZaJednako) //da bi operacije mogle da budu nadovezane
        {
            //dodatne provere da prethodno nije bila operacija brisanja ili tacka jer onda nije jos potrebno do se updatuje vrednost zaOperacije
            if (sabZaJednako && !brisanjeCifre && !tacka && !promenaZnaka)
            {
                zaOperacije += vrednost;
                sabZaJednako = false;
            }
            else if (oduZaJednako && !brisanjeCifre && !tacka && !promenaZnaka)
            {
                zaOperacije -= vrednost;
                oduZaJednako = false;
            }
            else if (mnoZaJednako && !brisanjeCifre && !tacka && !promenaZnaka)
            {
                zaOperacije *= vrednost;
                mnoZaJednako = false;
            }
            else if (delZaJednako && !brisanjeCifre && !tacka && !promenaZnaka)
            {
                if (vrednost != 0)
                    zaOperacije /= vrednost;
                else
                {
                    QString nonumb = "nan";
                    zaOperacije = nonumb.toDouble();
                }
                delZaJednako = false;
            }
        }
        else
        {
            zaOperacije = vrednost;
        }
        if (sabiranje || oduzimanje || mnozenje || deljenje) //neka od binarnih operacija
        {
            if (sabiranje)
            {
                zaIstoriju += rezultat + " + ";
                sabiranje = false;
                sabZaJednako = true;
            }
            else if (oduzimanje)
            {
                zaIstoriju += rezultat + " - ";
                oduzimanje = false;
                oduZaJednako = true;
            }
            else if (mnozenje)
            {
                zaIstoriju += rezultat + " * ";
                mnozenje = false;
                mnoZaJednako = true;
            }
            else
            {
                zaIstoriju += rezultat + " / ";
                deljenje = false;
                delZaJednako = true;
            }
            rezultat = "";
        }
        else if (jednako)
        {
            jednako = false;
            jednakoPoslednje = true;
            zaIstoriju += QString::number(vrednost);
            rezultat = QString::number(zaOperacije);
            vrednost = zaOperacije;
            zaIstoriju += " = " + rezultat;
            //updatuje se i istorija
            emit resultHistoryChanged(rezultat);
        }
        else if (korenovanje)
        {
           korenovanje = false;
           double novaVred = qSqrt(zaOperacije);
           //ukoliko je koren iz negativnog broja funkcija vraca NAN
           vrednost = novaVred;
           rezultat = QString::number(vrednost);
           //ako je potrebno da se updatuje se i istorija
           //zaIstoriju = "√" + QString::number(zaOperacije) + " = " + rezultat;
           //emit resultHistoryChanged(rezultat);
        }
        else if (promenaZnaka)
        {
            promenaZnaka = false;
            double novaVred = (-1)* vrednost;
            vrednost = novaVred;
            rezultat = QString::number(vrednost);
            //ako je potrebno da se updatuje se i istorija
            //zaIstoriju = "±" + QString::number(novaVred);
            //emit resultHistoryChanged(rezultat);
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
            if (vrednost != 0)
            {
                QString novaVred = rezultat;
                novaVred.chop(1);
                if (novaVred.compare("") == 0 || novaVred.compare("-") == 0) //treba proveri da ne ostane minus
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
            else
            {
                if (rezultat.contains("."))
                    rezultat.chop(1);
            }
        }
        else //tacka
        {
            tacka = false;
            jednakoPoslednje = false; //da bi osigurali da ukoliko nova cifra posle = bude broj.broj
            if (!rezultat.contains("."))
            {
                QString novaVred = QString::number(vrednost)+".";
                vrednost = novaVred.toDouble();
                rezultat = novaVred;
            }
        }
    }
    emit resultChanged(rezultat);
}
