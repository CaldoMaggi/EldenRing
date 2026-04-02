using UnityEngine;

public interface IDañable
{
    int Vida { get; set; } //metodo properties o get o set
    void RecibirDanio(int danio); // Método para recibir daño
}
