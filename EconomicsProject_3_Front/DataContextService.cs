using EconomicsProject_3_Core.Data;

namespace EconomicsProject_3_Front;

public class DataContextService
{
    DataContext dataContext;

    public DataContextService(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public DataContext GetDataContext()
    {
        return dataContext;
    }
}
