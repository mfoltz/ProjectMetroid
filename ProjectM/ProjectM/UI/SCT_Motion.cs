// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SCT_Motion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class SCT_Motion : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Motion;
    private static readonly IntPtr NativeFieldInfoPtr_XPos_FromTo;
    private static readonly IntPtr NativeFieldInfoPtr_XPos_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_YPos_FromTo;
    private static readonly IntPtr NativeFieldInfoPtr_YPos_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_ZPos_FromTo;
    private static readonly IntPtr NativeFieldInfoPtr_ZPos_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_Scale_FromTo;
    private static readonly IntPtr NativeFieldInfoPtr_Scale_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_Alpha_FromTo;
    private static readonly IntPtr NativeFieldInfoPtr_Alpha_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_Force;
    private static readonly IntPtr NativeFieldInfoPtr_Force_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_RandomXZ;
    private static readonly IntPtr NativeFieldInfoPtr_RandomXZ_Curve;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SCT_Motion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SCT_Motion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SCT_Motion()
    {
      Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (SCT_Motion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr);
      SCT_Motion.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Motion));
      SCT_Motion.NativeFieldInfoPtr_XPos_FromTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (XPos_FromTo));
      SCT_Motion.NativeFieldInfoPtr_XPos_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (XPos_Curve));
      SCT_Motion.NativeFieldInfoPtr_YPos_FromTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (YPos_FromTo));
      SCT_Motion.NativeFieldInfoPtr_YPos_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (YPos_Curve));
      SCT_Motion.NativeFieldInfoPtr_ZPos_FromTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (ZPos_FromTo));
      SCT_Motion.NativeFieldInfoPtr_ZPos_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (ZPos_Curve));
      SCT_Motion.NativeFieldInfoPtr_Scale_FromTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Scale_FromTo));
      SCT_Motion.NativeFieldInfoPtr_Scale_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Scale_Curve));
      SCT_Motion.NativeFieldInfoPtr_Alpha_FromTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Alpha_FromTo));
      SCT_Motion.NativeFieldInfoPtr_Alpha_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Alpha_Curve));
      SCT_Motion.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Force));
      SCT_Motion.NativeFieldInfoPtr_Force_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (Force_Curve));
      SCT_Motion.NativeFieldInfoPtr_RandomXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (RandomXZ));
      SCT_Motion.NativeFieldInfoPtr_RandomXZ_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, nameof (RandomXZ_Curve));
      SCT_Motion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCT_Motion>.NativeClassPtr, 100692294);
    }

    public SCT_Motion(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SCTMotionOptions Motion
    {
      get
      {
        return *(SCTMotionOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Motion));
      }
      [param: In] set
      {
        *(SCTMotionOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Motion)) = value;
      }
    }

    public unsafe FloatMinMax XPos_FromTo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_XPos_FromTo));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_XPos_FromTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData XPos_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_XPos_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_XPos_Curve)) = value;
      }
    }

    public unsafe FloatMinMax YPos_FromTo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_YPos_FromTo));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_YPos_FromTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData YPos_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_YPos_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_YPos_Curve)) = value;
      }
    }

    public unsafe FloatMinMax ZPos_FromTo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_ZPos_FromTo));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_ZPos_FromTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData ZPos_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_ZPos_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_ZPos_Curve)) = value;
      }
    }

    public unsafe FloatMinMax Scale_FromTo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Scale_FromTo));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Scale_FromTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData Scale_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Scale_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Scale_Curve)) = value;
      }
    }

    public unsafe FloatMinMax Alpha_FromTo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Alpha_FromTo));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Alpha_FromTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData Alpha_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Alpha_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Alpha_Curve)) = value;
      }
    }

    public unsafe float Force
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Force));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Force)) = value;
      }
    }

    public unsafe CurveData Force_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Force_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_Force_Curve)) = value;
      }
    }

    public unsafe FloatMinMax RandomXZ
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_RandomXZ));
        return pointer == IntPtr.Zero ? (FloatMinMax) null : new FloatMinMax(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_RandomXZ), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveData RandomXZ_Curve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_RandomXZ_Curve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCT_Motion.NativeFieldInfoPtr_RandomXZ_Curve)) = value;
      }
    }
  }
}
