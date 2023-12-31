// Decompiled with JetBrains decompiler
// Type: ProjectM.ResistanceHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;

#nullable disable
namespace ProjectM
{
  public static class ResistanceHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSunExposeTimeReductionFactor_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageReductionVsFire_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageReductionVsHoly_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageReductionVsGarlic_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageReductionVsSilver_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageReductionVsPlayers_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSilverCarryStackValueAbsorbed_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageAbsorbVsRadialHoly_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGarlicExposureTimeModifier_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGarlicReducedMaxStacks_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIgniteExtinguishChance_Public_Static_Single_ModifiableInt_ResistanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTooltip_Public_Static_String_ResistanceType_ModifiableInt_LocalizationKey_ResistanceData_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749169, RefRangeEnd = 749170, XrefRangeStart = 749168, XrefRangeEnd = 749169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetSunExposeTimeReductionFactor(
      ModifiableInt sunResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sunResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetSunExposeTimeReductionFactor_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749173, RefRangeEnd = 749175, XrefRangeStart = 749170, XrefRangeEnd = 749173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageReductionVsFire(
      ModifiableInt fireResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fireResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsFire_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749178, RefRangeEnd = 749180, XrefRangeStart = 749175, XrefRangeEnd = 749178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageReductionVsHoly(
      ModifiableInt holyResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &holyResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsHoly_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749183, RefRangeEnd = 749185, XrefRangeStart = 749180, XrefRangeEnd = 749183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageReductionVsGarlic(
      ModifiableInt garlicResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &garlicResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsGarlic_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749188, RefRangeEnd = 749190, XrefRangeStart = 749185, XrefRangeEnd = 749188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageReductionVsSilver(
      ModifiableInt silverResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &silverResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsSilver_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749193, RefRangeEnd = 749194, XrefRangeStart = 749190, XrefRangeEnd = 749193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageReductionVsPlayers(
      ModifiableInt PvPResilience,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &PvPResilience;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsPlayers_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 749195, RefRangeEnd = 749198, XrefRangeStart = 749194, XrefRangeEnd = 749195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetSilverCarryStackValueAbsorbed(
      ModifiableInt silverResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &silverResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetSilverCarryStackValueAbsorbed_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 749199, RefRangeEnd = 749203, XrefRangeStart = 749198, XrefRangeEnd = 749199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamageAbsorbVsRadialHoly(
      ModifiableInt holyResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &holyResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetDamageAbsorbVsRadialHoly_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749204, RefRangeEnd = 749206, XrefRangeStart = 749203, XrefRangeEnd = 749204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetGarlicExposureTimeModifier(
      ModifiableInt garlicResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &garlicResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetGarlicExposureTimeModifier_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749209, RefRangeEnd = 749210, XrefRangeStart = 749206, XrefRangeEnd = 749209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetGarlicReducedMaxStacks(
      ModifiableInt garlicResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &garlicResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetGarlicReducedMaxStacks_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749211, RefRangeEnd = 749212, XrefRangeStart = 749210, XrefRangeEnd = 749211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetIgniteExtinguishChance(
      ModifiableInt fireResistance,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fireResistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetIgniteExtinguishChance_Public_Static_Single_ModifiableInt_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 749234, RefRangeEnd = 749239, XrefRangeStart = 749212, XrefRangeEnd = 749234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetTooltip(
      ResistanceHelper.ResistanceType resistanceType,
      ModifiableInt rating,
      LocalizationKey key,
      ResistanceData resistanceData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &resistanceType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rating;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &resistanceData;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ResistanceHelper.NativeMethodInfoPtr_GetTooltip_Public_Static_String_ResistanceType_ModifiableInt_LocalizationKey_ResistanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static ResistanceHelper()
    {
      Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ResistanceHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr);
      ResistanceHelper.NativeMethodInfoPtr_GetSunExposeTimeReductionFactor_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665979);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsFire_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665980);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsHoly_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665981);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsGarlic_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665982);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsSilver_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665983);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageReductionVsPlayers_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665984);
      ResistanceHelper.NativeMethodInfoPtr_GetSilverCarryStackValueAbsorbed_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665985);
      ResistanceHelper.NativeMethodInfoPtr_GetDamageAbsorbVsRadialHoly_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665986);
      ResistanceHelper.NativeMethodInfoPtr_GetGarlicExposureTimeModifier_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665987);
      ResistanceHelper.NativeMethodInfoPtr_GetGarlicReducedMaxStacks_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665988);
      ResistanceHelper.NativeMethodInfoPtr_GetIgniteExtinguishChance_Public_Static_Single_ModifiableInt_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665989);
      ResistanceHelper.NativeMethodInfoPtr_GetTooltip_Public_Static_String_ResistanceType_ModifiableInt_LocalizationKey_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceHelper>.NativeClassPtr, 100665990);
    }

    public ResistanceHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public enum ResistanceType
    {
      Fire,
      Garlic,
      Holy,
      Silver,
      Sun,
      PvPResilience,
    }
  }
}
