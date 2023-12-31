// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Innocent_80
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Innocent_80
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_RollPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinChanceToRestAbilityCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxChanceToRestAbilityCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public AssetGuid SCT;
    [FieldOffset(16)]
    public PrefabGUID RollPrefabGUID;
    [FieldOffset(20)]
    public float MinChanceToRestAbilityCooldown;
    [FieldOffset(24)]
    public float MaxChanceToRestAbilityCooldown;
    [FieldOffset(28)]
    public float RequiredBloodPercentage;

    static BloodBuffScript_Innocent_80()
    {
      Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Innocent_80));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr);
      BloodBuffScript_Innocent_80.NativeFieldInfoPtr_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, nameof (SCT));
      BloodBuffScript_Innocent_80.NativeFieldInfoPtr_RollPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, nameof (RollPrefabGUID));
      BloodBuffScript_Innocent_80.NativeFieldInfoPtr_MinChanceToRestAbilityCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, nameof (MinChanceToRestAbilityCooldown));
      BloodBuffScript_Innocent_80.NativeFieldInfoPtr_MaxChanceToRestAbilityCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, nameof (MaxChanceToRestAbilityCooldown));
      BloodBuffScript_Innocent_80.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Innocent_80>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
