#include "chartpointdialog.h"
#include "ui_chartpointdialog.h"

ChartPointDialog::ChartPointDialog(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::ChartPointDialog)
{
    ui->setupUi(this);
}

ChartPointDialog::~ChartPointDialog()
{
    delete ui;
}

QString ChartPointDialog::getLabel()
{
    QString label = ui->labelEdit->text();
    return label;
}

float ChartPointDialog::getValue()
{
    float value = ui->valueEdit->text().toFloat();
    return value;
}

QColor ChartPointDialog::getColor()
{
    QColor color;
    color.setNamedColor(ui->colorEdit->text());
    return color;
}


void ChartPointDialog::on_colorButton_clicked()
{
    QColorDialog colorDialog;
    if(colorDialog.exec() == QDialog::Accepted)
    {
        QColor temp = colorDialog.selectedColor();
        ui->colorEdit->setText(temp.name());
    }
}
