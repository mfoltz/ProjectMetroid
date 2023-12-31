// Decompiled with JetBrains decompiler
// Type: ProjectM.DamageCategoryStats
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct DamageCategoryStats
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsUndeads;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsHumans;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsDemons;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsMechanical;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsBeasts;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsCastleObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsPlayerVampires;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsWood;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsMineral;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsVegetation;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsLightArmor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsHeavyArmor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageVsMagic;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_DamageCategoryStats_0;
    [FieldOffset(0)]
    public ModifiableFloat DamageVsUndeads;
    [FieldOffset(8)]
    public ModifiableFloat DamageVsHumans;
    [FieldOffset(16)]
    public ModifiableFloat DamageVsDemons;
    [FieldOffset(24)]
    public ModifiableFloat DamageVsMechanical;
    [FieldOffset(32)]
    public ModifiableFloat DamageVsBeasts;
    [FieldOffset(40)]
    public ModifiableFloat DamageVsCastleObjects;
    [FieldOffset(48)]
    public ModifiableFloat DamageVsPlayerVampires;
    [FieldOffset(56)]
    public ModifiableFloat DamageVsWood;
    [FieldOffset(64)]
    public ModifiableFloat DamageVsMineral;
    [FieldOffset(72)]
    public ModifiableFloat DamageVsVegetation;
    [FieldOffset(80)]
    public ModifiableFloat DamageVsLightArmor;
    [FieldOffset(88)]
    public ModifiableFloat DamageVsHeavyArmor;
    [FieldOffset(96)]
    public ModifiableFloat DamageVsMagic;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762897, RefRangeEnd = 762898, XrefRangeStart = 762884, XrefRangeEnd = 762897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DamageCategoryStats Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DamageCategoryStats.NativeMethodInfoPtr_Default_Public_Static_DamageCategoryStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DamageCategoryStats*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DamageCategoryStats()
    {
      Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DamageCategoryStats));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr);
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsUndeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsUndeads));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsHumans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsHumans));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsDemons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsDemons));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsMechanical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsMechanical));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsBeasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsBeasts));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsCastleObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsCastleObjects));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsPlayerVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsPlayerVampires));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsWood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsWood));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsMineral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsMineral));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsVegetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsVegetation));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsLightArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsLightArmor));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsHeavyArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsHeavyArmor));
      DamageCategoryStats.NativeFieldInfoPtr_DamageVsMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, nameof (DamageVsMagic));
      DamageCategoryStats.NativeMethodInfoPtr_Default_Public_Static_DamageCategoryStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, 100667402);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageCategoryStats>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
