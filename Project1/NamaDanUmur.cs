using System;

class NamaDanUmur
{
    private string m_sName;
    private string m_sAge;

    public NamaDanUmur (string[] args)
    {
        m_sName = args[0];
        m_sAge = args[1];
    }

    public override string ToString()
    {
        return string.Format("Her name is {0} and she's {1} years old.", m_sName, m_sAge);
    }
}