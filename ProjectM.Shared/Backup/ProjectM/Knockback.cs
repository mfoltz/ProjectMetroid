// Decompiled with JetBrains decompiler
// Type: ProjectM.Knockback
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Knockback
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanCastModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanMoveModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplyStun;
    [FieldOffset(0)]
    public ModificationId CanCastModId;
    [FieldOffset(4)]
    public ModificationId CanMoveModId;
    [FieldOffset(8)]
    public int Importance;
    [FieldOffset(12)]
    public bool ApplyStun;

    static Knockback()
    {
      Il2CppClassPointerStore<Knockback>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Knockback));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Knockback>.NativeClassPtr);
      Knockback.NativeFieldInfoPtr_CanCastModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Knockback>.NativeClassPtr, nameof (CanCastModId));
      Knockback.NativeFieldInfoPtr_CanMoveModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Knockback>.NativeClassPtr, nameof (CanMoveModId));
      Knockback.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Knockback>.NativeClassPtr, nameof (Importance));
      Knockback.NativeFieldInfoPtr_ApplyStun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Knockback>.NativeClassPtr, nameof (ApplyStun));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Knockback>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
