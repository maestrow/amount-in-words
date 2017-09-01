# Сумма, дата и деньги прописью

Изначально код был взят по адресу http://notesatprograming.blogspot.ru/2011/10/public-enum-textcase-nominative.html, Автор: Антон Зубарев.

Возможности библиотеки:

- Сумма прописью в разных падежах
- Сумма прописью в рублях и копейках
- Дата прописью
- Месяц прописью в разных падежах

Для месяцев прописаны не все падежи, однако их легко дописать при необходимости и сделать Pull Request.

## Компиляция

`csc .\amountInWords.cs /t:library`

## Демо возможностей

`demo.fsx` - Скрипт на F#, демонстрирующий возможности библиотеку. Запустить скрипт можно командой `fsi demo.fsx` (необходимо наличие amountInWords.dll, см. пункт "Компиляция").