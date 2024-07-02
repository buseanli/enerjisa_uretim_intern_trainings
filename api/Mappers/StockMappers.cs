using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs;
using api.DTOs.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel){
            return new StockDto{
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto StockDto)
    {
        return new Stock
        {
            Symbol = StockDto.Symbol,
            CompanyName = StockDto.CompanyName,
            Purchase = StockDto.Purchase,
            LastDiv = StockDto.LastDiv,
            Industry = StockDto.Industry,
            MarketCap = StockDto.MarketCap,

        };
    }
    }
}