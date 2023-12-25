// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DTimeline
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public class Motion2DTimeline : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Clips;
    private static readonly System.IntPtr NativeFieldInfoPtr__EvaluateBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__Comparison;
    private static readonly System.IntPtr NativeFieldInfoPtr__Owner;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_byref_List_1_EvaluateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Private_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_byref_EvaluateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_byref_Motion2DTimelineBinding_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClipTime_Public_Static_Single_Single_Motion2DClip_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Boolean_String_byref_Motion2DTimelineBinding_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Boolean_Il2CppStructArray_1_Byte_byref_Motion2DTimelineBinding_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ByteArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

    public unsafe UnityEngine.Object Owner
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_get_Owner_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923246, XrefRangeEnd = 923252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DTimeline(UnityEngine.Object owner)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923252, XrefRangeEnd = 923257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(
      Il2CppReferenceArray<Motion2DTimelineBinding> bindings,
      float t,
      out List<Motion2DTimeline.EvaluateData> tempBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bindings);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_byref_List_1_EvaluateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<Motion2DTimeline.EvaluateData> local = ref tempBuffer;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<Motion2DTimeline.EvaluateData>) list;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 923356, RefRangeEnd = 923358, XrefRangeStart = 923257, XrefRangeEnd = 923356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(
      Il2CppReferenceArray<Motion2DTimelineBinding> bindings,
      float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bindings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923358, XrefRangeEnd = 923359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(
      Il2CppReferenceArray<Motion2DTimelineBinding> bindings,
      ref Motion2DTimeline.EvaluateData evalData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bindings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evalData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Private_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_byref_EvaluateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923359, XrefRangeEnd = 923373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(ref Motion2DTimelineBinding binding, float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) binding);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_byref_Motion2DTimelineBinding_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923373, XrefRangeEnd = 923375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetClipTime(float t, Motion2DClip clip)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_GetClipTime_Public_Static_Single_Single_Motion2DClip_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923375, XrefRangeEnd = 923377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DClip GetClip(Il2CppStructArray<byte> guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Motion2DClip) null : new Motion2DClip(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923377, XrefRangeEnd = 923379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DClip GetClip(Il2CppStructArray<byte> guid, out int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Motion2DClip) null : new Motion2DClip(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923379, XrefRangeEnd = 923383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBinding(string clipName, ref Motion2DTimelineBinding binding)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(clipName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) binding);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_GetBinding_Public_Boolean_String_byref_Motion2DTimelineBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923383, XrefRangeEnd = 923387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBinding(Il2CppStructArray<byte> guid, ref Motion2DTimelineBinding binding)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) binding);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_GetBinding_Public_Boolean_Il2CppStructArray_1_Byte_byref_Motion2DTimelineBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923387, XrefRangeEnd = 923388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ByteArrayEquals(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.NativeMethodInfoPtr_ByteArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Motion2DTimeline()
    {
      Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DTimeline));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr);
      Motion2DTimeline.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, nameof (Clips));
      Motion2DTimeline.NativeFieldInfoPtr__EvaluateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, nameof (_EvaluateBuffer));
      Motion2DTimeline.NativeFieldInfoPtr__Comparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, nameof (_Comparison));
      Motion2DTimeline.NativeFieldInfoPtr__Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, nameof (_Owner));
      Motion2DTimeline.NativeMethodInfoPtr_get_Owner_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663858);
      Motion2DTimeline.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663859);
      Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_byref_List_1_EvaluateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663860);
      Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663861);
      Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Private_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_byref_EvaluateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663862);
      Motion2DTimeline.NativeMethodInfoPtr_Evaluate_Public_Void_byref_Motion2DTimelineBinding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663863);
      Motion2DTimeline.NativeMethodInfoPtr_GetClipTime_Public_Static_Single_Single_Motion2DClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663864);
      Motion2DTimeline.NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663865);
      Motion2DTimeline.NativeMethodInfoPtr_GetClip_Public_Motion2DClip_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663866);
      Motion2DTimeline.NativeMethodInfoPtr_GetBinding_Public_Boolean_String_byref_Motion2DTimelineBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663867);
      Motion2DTimeline.NativeMethodInfoPtr_GetBinding_Public_Boolean_Il2CppStructArray_1_Byte_byref_Motion2DTimelineBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663868);
      Motion2DTimeline.NativeMethodInfoPtr_ByteArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, 100663869);
    }

    public Motion2DTimeline(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Motion2DClip> Clips
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimeline.NativeFieldInfoPtr_Clips));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Motion2DClip>) null : new Il2CppReferenceArray<Motion2DClip>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimeline.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<Motion2DTimeline.EvaluateData> _EvaluateBuffer
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Motion2DTimeline.NativeFieldInfoPtr__EvaluateBuffer, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<Motion2DTimeline.EvaluateData>) null : new List<Motion2DTimeline.EvaluateData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Motion2DTimeline.NativeFieldInfoPtr__EvaluateBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData> _Comparison
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Motion2DTimeline.NativeFieldInfoPtr__Comparison, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData>) null : new Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Motion2DTimeline.NativeFieldInfoPtr__Comparison, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.Object _Owner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimeline.NativeFieldInfoPtr__Owner));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimeline.NativeFieldInfoPtr__Owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EvaluateData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Time;
      private static readonly System.IntPtr NativeFieldInfoPtr_RelativeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClipIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_BindingIndex;
      [FieldOffset(0)]
      public float Time;
      [FieldOffset(4)]
      public float RelativeTime;
      [FieldOffset(8)]
      public int ClipIndex;
      [FieldOffset(12)]
      public int BindingIndex;

      static EvaluateData()
      {
        Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, nameof (EvaluateData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr);
        Motion2DTimeline.EvaluateData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr, nameof (Time));
        Motion2DTimeline.EvaluateData.NativeFieldInfoPtr_RelativeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr, nameof (RelativeTime));
        Motion2DTimeline.EvaluateData.NativeFieldInfoPtr_ClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr, nameof (ClipIndex));
        Motion2DTimeline.EvaluateData.NativeFieldInfoPtr_BindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr, nameof (BindingIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DTimeline.EvaluateData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("StunShared.UI.Motion2DTimeline/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Int32_EvaluateData_EvaluateData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923245, XrefRangeEnd = 923246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Evaluate_b__9_0(
        Motion2DTimeline.EvaluateData x,
        Motion2DTimeline.EvaluateData y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DTimeline.__c.NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Int32_EvaluateData_EvaluateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Motion2DTimeline>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr);
        Motion2DTimeline.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr, "<>9");
        Motion2DTimeline.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr, "<>9__9_0");
        Motion2DTimeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr, 100663871);
        Motion2DTimeline.__c.NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Int32_EvaluateData_EvaluateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimeline.__c>.NativeClassPtr, 100663872);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Motion2DTimeline.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Motion2DTimeline.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Motion2DTimeline.__c) null : new Motion2DTimeline.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Motion2DTimeline.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData> __9__9_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Motion2DTimeline.__c.NativeFieldInfoPtr___9__9_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData>) null : new Il2CppSystem.Comparison<Motion2DTimeline.EvaluateData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Motion2DTimeline.__c.NativeFieldInfoPtr___9__9_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
