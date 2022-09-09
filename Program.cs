//Alteraçao V2
//Alteraçao V3
//Alteraçao V4
new Panda().Marry(new Panda());
public class Panda
{
  public Panda Mate;

  public void Marry(Panda partner)
  {
    Mate = partner;
    partner.Mate = this;
  }
}
