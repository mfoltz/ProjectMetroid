// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPrediction
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class AimPrediction : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FirstOrderIntercept_Public_Static_float2_float2_float2_Single_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FirstOrderInterceptTime_Public_Static_Single_Single_float2_float2_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 974389, RefRangeEnd = 974390, XrefRangeStart = 974388, XrefRangeEnd = 974389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 FirstOrderIntercept(
      float2 shooterPosition,
      float2 shooterVelocity,
      float shotSpeed,
      float2 targetPosition,
      float2 targetVelocity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &shooterPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shooterVelocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &shotSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetVelocity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimPrediction.NativeMethodInfoPtr_FirstOrderIntercept_Public_Static_float2_float2_float2_Single_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 974394, RefRangeEnd = 974395, XrefRangeStart = 974390, XrefRangeEnd = 974394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float FirstOrderInterceptTime(
      float shotSpeed,
      float2 targetRelativePosition,
      float2 targetRelativeVelocity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &shotSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetRelativePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetRelativeVelocity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimPrediction.NativeMethodInfoPtr_FirstOrderInterceptTime_Public_Static_Single_Single_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AimPrediction()
    {
      Il2CppClassPointerStore<AimPrediction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPrediction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPrediction>.NativeClassPtr);
      AimPrediction.NativeMethodInfoPtr_FirstOrderIntercept_Public_Static_float2_float2_float2_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimPrediction>.NativeClassPtr, 100675300);
      AimPrediction.NativeMethodInfoPtr_FirstOrderInterceptTime_Public_Static_Single_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimPrediction>.NativeClassPtr, 100675301);
    }

    public AimPrediction(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
