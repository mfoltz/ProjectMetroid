// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormStrikeSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningStormStrikeSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StrikeRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomPositionWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateModifierCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateModifierCurveDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrikeRateCurveModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningStrikes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningStrikesTotalWeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRateModifier_Public_Single_byref_CurveCollection_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStrikeDuration_Public_Single_byref_Random_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStrike_Public_LightningStrikeData_byref_Random_0;
    [FieldOffset(0)]
    public MinMaxFloat StrikeRate;
    [FieldOffset(8)]
    public float RandomPositionWeight;
    [FieldOffset(12)]
    public CurveReference RateModifierCurve;
    [FieldOffset(20)]
    public float RateModifierCurveDuration;
    [FieldOffset(24)]
    public MinMaxFloat StrikeRateCurveModifier;
    [FieldOffset(32)]
    public BlobArray<LightningStrikeData> LightningStrikes;
    [FieldOffset(40)]
    public float LightningStrikesTotalWeight;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1116784, RefRangeEnd = 1116786, XrefRangeStart = 1116782, XrefRangeEnd = 1116784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetRateModifier([In] ref CurveCollection curves, double time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref curves;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormStrikeSettings.NativeMethodInfoPtr_GetRateModifier_Public_Single_byref_CurveCollection_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1116786, RefRangeEnd = 1116788, XrefRangeStart = 1116786, XrefRangeEnd = 1116786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetStrikeDuration(ref Unity.Mathematics.Random random, float area)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &area;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormStrikeSettings.NativeMethodInfoPtr_GetStrikeDuration_Public_Single_byref_Random_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1116792, RefRangeEnd = 1116794, XrefRangeStart = 1116788, XrefRangeEnd = 1116792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningStrikeData GetStrike(ref Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormStrikeSettings.NativeMethodInfoPtr_GetStrike_Public_LightningStrikeData_byref_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LightningStrikeData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LightningStormStrikeSettings()
    {
      Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormStrikeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr);
      LightningStormStrikeSettings.NativeFieldInfoPtr_StrikeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (StrikeRate));
      LightningStormStrikeSettings.NativeFieldInfoPtr_RandomPositionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (RandomPositionWeight));
      LightningStormStrikeSettings.NativeFieldInfoPtr_RateModifierCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (RateModifierCurve));
      LightningStormStrikeSettings.NativeFieldInfoPtr_RateModifierCurveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (RateModifierCurveDuration));
      LightningStormStrikeSettings.NativeFieldInfoPtr_StrikeRateCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (StrikeRateCurveModifier));
      LightningStormStrikeSettings.NativeFieldInfoPtr_LightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (LightningStrikes));
      LightningStormStrikeSettings.NativeFieldInfoPtr_LightningStrikesTotalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, nameof (LightningStrikesTotalWeight));
      LightningStormStrikeSettings.NativeMethodInfoPtr_GetRateModifier_Public_Single_byref_CurveCollection_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, 100688496);
      LightningStormStrikeSettings.NativeMethodInfoPtr_GetStrikeDuration_Public_Single_byref_Random_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, 100688497);
      LightningStormStrikeSettings.NativeMethodInfoPtr_GetStrike_Public_LightningStrikeData_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, 100688498);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormStrikeSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
