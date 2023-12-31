// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Salvageable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Salvageable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SalvageFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SalvageTimer;
    [FieldOffset(0)]
    public PrefabGUID RecipeGUID;
    [FieldOffset(4)]
    public float SalvageFactor;
    [FieldOffset(8)]
    public float SalvageTimer;

    static Salvageable()
    {
      Il2CppClassPointerStore<Salvageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (Salvageable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Salvageable>.NativeClassPtr);
      Salvageable.NativeFieldInfoPtr_RecipeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvageable>.NativeClassPtr, nameof (RecipeGUID));
      Salvageable.NativeFieldInfoPtr_SalvageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvageable>.NativeClassPtr, nameof (SalvageFactor));
      Salvageable.NativeFieldInfoPtr_SalvageTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvageable>.NativeClassPtr, nameof (SalvageTimer));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Salvageable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
