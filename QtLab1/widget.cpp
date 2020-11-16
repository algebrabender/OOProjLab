#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget),
    calculatorLogic(new CalculatorLogic(this))
{
    ui->setupUi(this);
    ui->displayRezultata->setText("0");
    connect(ui->button0, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button1, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button2, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button3, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button4, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button5, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button6, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button7, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button8, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button9, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->plus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->minus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->puta, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->podeljeno, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->jednako, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->koren, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->promenaZnaka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->clear, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->tacka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->backspace, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(calculatorLogic, SIGNAL(resultChanged(QString)), this, SLOT(onResultChanged()));
    connect(calculatorLogic, SIGNAL(resultHistoryChanged(QString)), this, SLOT(onResultHistoryChanged()));

}

Widget::~Widget()
{
    delete ui;
}

void Widget::onBtnClicked()
{
    QPushButton* button = (QPushButton *)sender();
    calculatorLogic->doCommand(button->text());
}

void Widget::onResultChanged()
{
    ui->displayRezultata->setText(calculatorLogic->rezultat);
}

void Widget::onResultHistoryChanged()
{
    ui->istorija->insertPlainText(calculatorLogic->zaIstoriju + "\n");
}
