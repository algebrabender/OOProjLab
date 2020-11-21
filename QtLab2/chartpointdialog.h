#ifndef CHARTPOINTDIALOG_H
#define CHARTPOINTDIALOG_H

#include <QDialog>
#include <QColorDialog>

namespace Ui {
class ChartPointDialog;
}

class ChartPointDialog : public QDialog
{
    Q_OBJECT

public:
    explicit ChartPointDialog(QWidget *parent = nullptr);
    ~ChartPointDialog();

    QString getLabel();
    float getValue();
    QColor getColor();

private slots:
    void on_colorButton_clicked();

private:
    Ui::ChartPointDialog *ui;
};

#endif // CHARTPOINTDIALOG_H
