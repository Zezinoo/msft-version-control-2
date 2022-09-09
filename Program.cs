//Alteraçao V2
//Alteraçao V3
//Alteraçao V4
new Panda().Marry(new Panda());
//Alteraçao V3.1
public class Panda
{
  public Panda Mate;

  public void Marry(Panda partner)
  {
    Mate = partner;
    partner.Mate = this;
  }
  //Alteração V2.1
}
//Alteraçao V3.2 - Conflito Jose
