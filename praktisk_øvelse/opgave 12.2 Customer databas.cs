public class costumerdatabase
{
    public costumer[] Costumer;

    public costumerdatabase()
    {
        costumer = new costumer[10]; 
    }

    public void addcostumer(costumerdatabase)
    {
        for(int id = 0 ; id < costumer.Length ; id++)
        {
            if(costumer[id] == null)
            {
                costumer[id] = costumer;
                return;
            }
        }
    }
    public costumer[] getcostumeres()
    {  
        return Costumer;
    }
    public void namecostumeres()
    {
        for(int id = 0 ; id < Costumer.Length ; id++){
            Console.Write(Costumer[id]);
    }
}
}