public enum Faction{
    Player,
    Enemy
}

public interface IEntity{
    public Faction Faction{ get; }
    protected int CurrentHealth{ get; set; }
    protected int MaxHealth{ get; set; }

    public void TakeDamage(int damage);
    public void Heal(int heal);

    protected void Die();
}