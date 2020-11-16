#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include "CalculatorLogic.h"

QT_BEGIN_NAMESPACE

namespace Ui
{
    class Widget;
}

QT_END_NAMESPACE

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = 0);
    ~Widget();

public slots:
    void onBtnClicked();
    void onResultChanged();
    void onResultHistoryChanged();

private:
    Ui::Widget *ui;
    CalculatorLogic *calculatorLogic;
};
#endif // WIDGET_H
