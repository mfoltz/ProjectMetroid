// Decompiled with JetBrains decompiler
// Type: ProjectM.CurveReference
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
  public struct CurveReference
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FlipY;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_CurveCollection_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_CurveCollection_0;
    [FieldOffset(0)]
    public int CurveGuid;
    [FieldOffset(4)]
    public bool FlipY;

    public unsafe bool IsValid
    {
      [CallerCount(38), CachedScanResults(RefRangeStart = 723758, RefRangeEnd = 723796, XrefRangeStart = 723758, XrefRangeEnd = 723796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveReference.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723818, RefRangeEnd = 723819, XrefRangeStart = 723812, XrefRangeEnd = 723818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(
      float time,
      float duration,
      CurveCollection curveCollection,
      bool clamp = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clamp;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveReference.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_CurveCollection_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(75)]
    [CachedScanResults(RefRangeStart = 723825, RefRangeEnd = 723900, XrefRangeStart = 723819, XrefRangeEnd = 723825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(float t, CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveReference.NativeMethodInfoPtr_Evaluate_Public_Single_Single_CurveCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CurveReference()
    {
      Il2CppClassPointerStore<CurveReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CurveReference));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveReference>.NativeClassPtr);
      CurveReference.NativeFieldInfoPtr_CurveGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, nameof (CurveGuid));
      CurveReference.NativeFieldInfoPtr_FlipY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, nameof (FlipY));
      CurveReference.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, 100664010);
      CurveReference.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_CurveCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, 100664011);
      CurveReference.NativeMethodInfoPtr_Evaluate_Public_Single_Single_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, 100664012);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveReference>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
