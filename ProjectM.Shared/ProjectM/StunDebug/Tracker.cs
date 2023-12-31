// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.Tracker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class Tracker : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TrackedValues;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrackedPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemoveList;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackValue_Public_LinearFloatCurve_String_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackPosition_Public_LinearVector3Curve_String_Vector3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckInactiveValues_Internal_Void_DebugDrawComponent_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771880, RefRangeEnd = 771881, XrefRangeStart = 771858, XrefRangeEnd = 771880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Tracker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tracker>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Tracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771900, RefRangeEnd = 771901, XrefRangeStart = 771881, XrefRangeEnd = 771900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinearFloatCurve TrackValue(string name, float value, float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Tracker.NativeMethodInfoPtr_TrackValue_Public_LinearFloatCurve_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LinearFloatCurve) null : new LinearFloatCurve(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771920, RefRangeEnd = 771921, XrefRangeStart = 771901, XrefRangeEnd = 771920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinearVector3Curve TrackPosition(string name, Vector3 position, float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Tracker.NativeMethodInfoPtr_TrackPosition_Public_LinearVector3Curve_String_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LinearVector3Curve) null : new LinearVector3Curve(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771988, RefRangeEnd = 771989, XrefRangeStart = 771921, XrefRangeEnd = 771988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckInactiveValues(DebugDrawComponent drawComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) drawComponent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Tracker.NativeMethodInfoPtr_CheckInactiveValues_Internal_Void_DebugDrawComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Tracker()
    {
      Il2CppClassPointerStore<Tracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (Tracker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tracker>.NativeClassPtr);
      Tracker.NativeFieldInfoPtr__TrackedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tracker>.NativeClassPtr, nameof (_TrackedValues));
      Tracker.NativeFieldInfoPtr__TrackedPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tracker>.NativeClassPtr, nameof (_TrackedPositions));
      Tracker.NativeFieldInfoPtr__RemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tracker>.NativeClassPtr, nameof (_RemoveList));
      Tracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tracker>.NativeClassPtr, 100668355);
      Tracker.NativeMethodInfoPtr_TrackValue_Public_LinearFloatCurve_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tracker>.NativeClassPtr, 100668356);
      Tracker.NativeMethodInfoPtr_TrackPosition_Public_LinearVector3Curve_String_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tracker>.NativeClassPtr, 100668357);
      Tracker.NativeMethodInfoPtr_CheckInactiveValues_Internal_Void_DebugDrawComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tracker>.NativeClassPtr, 100668358);
    }

    public Tracker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<string, LinearFloatCurve> _TrackedValues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__TrackedValues));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, LinearFloatCurve>) null : new Dictionary<string, LinearFloatCurve>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__TrackedValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, LinearVector3Curve> _TrackedPositions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__TrackedPositions));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, LinearVector3Curve>) null : new Dictionary<string, LinearVector3Curve>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__TrackedPositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _RemoveList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__RemoveList));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tracker.NativeFieldInfoPtr__RemoveList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
