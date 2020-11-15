#include "CalculatorLogic.h"

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{
    trenutnaVrednost = 0.0;
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
}

void CalculatorLogic::doCommand(QString btn)
{
    if (btn.compare("+") == 0)
    {
        sabiranje = true;
        emit resultChanged(btn);
    }
    else if (btn.compare("-") == 0)
    {
        oduzimanje = true;
        emit resultChanged(btn);
    }
    else if (btn.compare("*") == 0)
    {
        mnozenje = true;
        emit resultChanged(btn);

    }
    else if (btn.compare("/") == 0)
    {
        deljenje = true;
        emit resultChanged(btn);

    }
    else if (btn.compare("=") == 0)
    {
        jednako = true;
        emit resultChanged(btn);
        emit resultHistoryChanged(btn);
    }
    else if (btn.compare("√") == 0)
    {
        korenovanje = true;
        emit resultChanged(btn);
        emit resultHistoryChanged(btn);
    }
    else if (btn.compare("±") == 0)
    {
        promenaZnaka = true;
        emit resultChanged(btn);
        emit resultHistoryChanged(btn);
    }
    else if (btn.compare("←") == 0)
    {
        brisanjeCifre = true;
        emit resultChanged(btn);
    }
    else if (btn.compare(".") == 0)
    {
        tacka = true;
        emit resultChanged(btn);
    }
    else if (btn.compare("C") == 0)
    {
        brisanje = true;
        emit resultChanged(btn);
    }
    else
    {
        trenutnaVrednost = btn.toDouble();
        emit resultChanged(btn);

    }
}
