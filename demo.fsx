#r "amountInWords.dll"

open System

let am = 37.67
let dt1 = DateTime.Now

printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Accusative, true, false)
printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Genitive, false, false)
printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Accusative, false, false)
printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Genitive, true, false)
printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Nominative, false, false)
printfn "%s" <| RuDateAndMoneyConverter.NumeralsToTxt(int64 am, TextCase.Nominative, true, false)

printfn "%s" <| String.Format("{0}{1}{2}{3}{4}{5}"
  , RuDateAndMoneyConverter.CurrencyToTxtFull(am, false)
  , Environment.NewLine
  , RuDateAndMoneyConverter.CurrencyToTxt(am, false)
  , Environment.NewLine
  , RuDateAndMoneyConverter.CurrencyToTxtShort(am, false)
  , Environment.NewLine
)

printfn "%s" <| String.Format("{0}{1}{2}{3}{4}{5}"
  , RuDateAndMoneyConverter.DateToTextQuarter(dt1)
  , Environment.NewLine
  , RuDateAndMoneyConverter.DateToTextSimple(dt1)
  , Environment.NewLine
  , RuDateAndMoneyConverter.DateToTextLong(dt1)
  , Environment.NewLine
)

printfn "%s" <| RuDateAndMoneyConverter.MonthName(2, TextCase.Nominative)