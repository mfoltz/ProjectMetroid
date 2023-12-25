// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningLight
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningLight
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntensityCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntensityMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntensityMax;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIntensity_Public_Single_Single_byref_CurveCollection_0;
    [FieldOffset(0)]
    public float Duration;
    [FieldOffset(4)]
    public float Angle;
    [FieldOffset(8)]
    public CurveReference IntensityCurve;
    [FieldOffset(16)]
    public float IntensityMin;
    [FieldOffset(20)]
    public float IntensityMax;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114702, RefRangeEnd = 1114703, XrefRangeStart = 1114701, XrefRangeEnd = 1114702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetIntensity(float t, [In] ref CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningLight.NativeMethodInfoPtr_GetIntensity_Public_Single_Single_byref_CurveCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LightningLight()
    {
      Il2CppClassPointerStore<LightningLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningLight));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningLight>.NativeClassPtr);
      LightningLight.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, nameof (Duration));
      LightningLight.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, nameof (Angle));
      LightningLight.NativeFieldInfoPtr_IntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, nameof (IntensityCurve));
      LightningLight.NativeFieldInfoPtr_IntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, nameof (IntensityMin));
      LightningLight.NativeFieldInfoPtr_IntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, nameof (IntensityMax));
      LightningLight.NativeMethodInfoPtr_GetIntensity_Public_Single_Single_byref_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, 100688249);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningLight>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
