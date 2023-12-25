// Decompiled with JetBrains decompiler
// Type: ProjectM.Forge_Shared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Forge_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialResourceMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialWeaponDurability;
    [FieldOffset(0)]
    public NetworkedEntity ItemEntity;
    [FieldOffset(16)]
    public double RepairStartTime;
    [FieldOffset(24)]
    public ForgeState State;
    [FieldOffset(28)]
    public float RepairTime;
    [FieldOffset(32)]
    public float InitialResourceMultiplier;
    [FieldOffset(36)]
    public float InitialWeaponDurability;

    static Forge_Shared()
    {
      Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Forge_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr);
      Forge_Shared.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (ItemEntity));
      Forge_Shared.NativeFieldInfoPtr_RepairStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (RepairStartTime));
      Forge_Shared.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (State));
      Forge_Shared.NativeFieldInfoPtr_RepairTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (RepairTime));
      Forge_Shared.NativeFieldInfoPtr_InitialResourceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (InitialResourceMultiplier));
      Forge_Shared.NativeFieldInfoPtr_InitialWeaponDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, nameof (InitialWeaponDurability));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Forge_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
