// Decompiled with JetBrains decompiler
// Type: ProjectM.HealUtility
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
  public static class HealUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHealing_Public_Static_Single_byref_Health_byref_UnitStats_byref_DealHealingParameters_Single_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 737293, RefRangeEnd = 737295, XrefRangeStart = 737291, XrefRangeEnd = 737293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float CalculateHealing(
      [In] ref Health targetHealth,
      [In] ref UnitStats healerUnitStats,
      [In] ref HealUtility.DealHealingParameters parameters,
      float multiplier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref targetHealth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref healerUnitStats;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &multiplier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HealUtility.NativeMethodInfoPtr_CalculateHealing_Public_Static_Single_byref_Health_byref_UnitStats_byref_DealHealingParameters_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HealUtility()
    {
      Il2CppClassPointerStore<HealUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HealUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealUtility>.NativeClassPtr);
      HealUtility.NativeMethodInfoPtr_CalculateHealing_Public_Static_Single_byref_Health_byref_UnitStats_byref_DealHealingParameters_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealUtility>.NativeClassPtr, 100665133);
    }

    public HealUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct DealHealingParameters_Editor
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthConstant;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthPercent;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthPerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_TrueHealing;
      private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_DealHealingParameters_0;
      [FieldOffset(0)]
      public float HealthConstant;
      [FieldOffset(4)]
      public float HealthPercent;
      [FieldOffset(8)]
      public float HealthPerSpellPower;
      [FieldOffset(12)]
      public bool TrueHealing;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 737289, RefRangeEnd = 737291, XrefRangeStart = 737289, XrefRangeEnd = 737289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HealUtility.DealHealingParameters Convert()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HealUtility.DealHealingParameters_Editor.NativeMethodInfoPtr_Convert_Public_DealHealingParameters_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HealUtility.DealHealingParameters*) IL2CPP.il2cpp_object_unbox(num);
      }

      static DealHealingParameters_Editor()
      {
        Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HealUtility>.NativeClassPtr, nameof (DealHealingParameters_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr);
        HealUtility.DealHealingParameters_Editor.NativeFieldInfoPtr_HealthConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, nameof (HealthConstant));
        HealUtility.DealHealingParameters_Editor.NativeFieldInfoPtr_HealthPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, nameof (HealthPercent));
        HealUtility.DealHealingParameters_Editor.NativeFieldInfoPtr_HealthPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, nameof (HealthPerSpellPower));
        HealUtility.DealHealingParameters_Editor.NativeFieldInfoPtr_TrueHealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, nameof (TrueHealing));
        HealUtility.DealHealingParameters_Editor.NativeMethodInfoPtr_Convert_Public_DealHealingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, 100665134);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HealUtility.DealHealingParameters_Editor>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DealHealingParameters
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthConstant;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthPercent;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthPerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_TrueHealing;
      [FieldOffset(0)]
      public float HealthConstant;
      [FieldOffset(4)]
      public float HealthPercent;
      [FieldOffset(8)]
      public float HealthPerSpellPower;
      [FieldOffset(12)]
      public bool TrueHealing;

      static DealHealingParameters()
      {
        Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HealUtility>.NativeClassPtr, nameof (DealHealingParameters));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr);
        HealUtility.DealHealingParameters.NativeFieldInfoPtr_HealthConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr, nameof (HealthConstant));
        HealUtility.DealHealingParameters.NativeFieldInfoPtr_HealthPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr, nameof (HealthPercent));
        HealUtility.DealHealingParameters.NativeFieldInfoPtr_HealthPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr, nameof (HealthPerSpellPower));
        HealUtility.DealHealingParameters.NativeFieldInfoPtr_TrueHealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr, nameof (TrueHealing));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HealUtility.DealHealingParameters>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
