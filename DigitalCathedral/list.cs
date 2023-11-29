namespace DigitalCathedral;

class list
{
    // public private protected internal
    internal int value1 = 0;

    private void private_insert()
    {
        
    }
    
    protected void insert(int value)
    {
        value1++;
        insert(value);
        private_insert();
    }
}

class list_derived : list
{
    void foo()
    {
        value1 = 10;
        //private_insert();
        insert(10);
    }
}