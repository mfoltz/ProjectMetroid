// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.LinearFloatCurve
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.StunDebug
{
  [Serializable]
  public class LinearFloatCurve : Curve<float, float>
  {
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Private_Static_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770795, XrefRangeEnd = 770806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LinearFloatCurve Create()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearFloatCurve.NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LinearFloatCurve) null : new LinearFloatCurve(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770806, XrefRangeEnd = 770822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LinearFloatCurve Create(
      float startTime,
      float startValue,
      float endTime,
      float endValue)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &startTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startValue;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &endTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &endValue;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearFloatCurve.NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_Single_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LinearFloatCurve) null : new LinearFloatCurve(pointer);
    }

    [CallerCount(0)]
    public static unsafe float Interpolate(float v1, float v2, float t)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &v1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &v2;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &t;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearFloatCurve.NativeMethodInfoPtr_Interpolate_Private_Static_Single_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770825, RefRangeEnd = 770826, XrefRangeStart = 770822, XrefRangeEnd = 770825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinearFloatCurve()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinearFloatCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinearFloatCurve()
    {
      Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (LinearFloatCurve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr);
      LinearFloatCurve.NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr, 100668271);
      LinearFloatCurve.NativeMethodInfoPtr_Create_Public_Static_LinearFloatCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr, 100668272);
      LinearFloatCurve.NativeMethodInfoPtr_Interpolate_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr, 100668273);
      LinearFloatCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearFloatCurve>.NativeClassPtr, 100668274);
    }

    public LinearFloatCurve(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
