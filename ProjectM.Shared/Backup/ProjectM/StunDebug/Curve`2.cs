// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.Curve`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.StunDebug
{
  public class Curve<Keyframe, Value> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Keyframes;
    private static readonly System.IntPtr NativeFieldInfoPtr__InterpolationFunc;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Protected_Static_T_Func_4_K_K_Single_V_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Value_Single_CurveWrapMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddKeyframe_Public_Void_Single_Keyframe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertKeyframe_Public_Int32_KeyframeItem_1_Keyframe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyframe_Public_KeyframeItem_1_Keyframe_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyframes_Public_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNumKeyframes_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKeyframesInFuture_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKeyframesInPast_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextKeyTime_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextValue_Public_Value_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentKeyframeTime_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFuture_Public_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasNewValue_Public_Boolean_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Curve_2_Keyframe_Value_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyframes_Public_Void_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyframes_Public_Void_IEnumerable_1_KeyframeItem_1_Keyframe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 770859, RefRangeEnd = 770863, XrefRangeStart = 770858, XrefRangeEnd = 770859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T Create<T, K, V>(Il2CppSystem.Func<K, K, float, V> func) where T : Curve<K, V>
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) func);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Curve<T, K>.MethodInfoStoreGeneric_Create_Protected_Static_T_Func_4_K_K_Single_V_0\u00603<V>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770863, XrefRangeEnd = 770866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Value GetValue(float time, CurveWrapMode wrapMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wrapMode;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetValue_Public_Value_Single_CurveWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<Value>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770866, XrefRangeEnd = 770868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddKeyframe(float time, Keyframe frame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      Keyframe& local1;
      if (!typeof (Keyframe).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<Keyframe> local2 = (object) frame;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (Keyframe&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (Keyframe&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref frame;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_AddKeyframe_Public_Void_Single_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770868, XrefRangeEnd = 770869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int InsertKeyframe(KeyframeItem<Keyframe> frame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frame));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_InsertKeyframe_Public_Int32_KeyframeItem_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 770869, RefRangeEnd = 770872, XrefRangeStart = 770869, XrefRangeEnd = 770869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KeyframeItem<Keyframe> GetKeyframe(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetKeyframe_Public_KeyframeItem_1_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new KeyframeItem<Keyframe>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770872, XrefRangeEnd = 770874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<KeyframeItem<Keyframe>> GetKeyframes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetKeyframes_Public_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<KeyframeItem<Keyframe>>) null : new Il2CppReferenceArray<KeyframeItem<Keyframe>>(nativeObject);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 770878, RefRangeEnd = 770897, XrefRangeStart = 770874, XrefRangeEnd = 770878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetNumKeyframes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNumKeyframes_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770897, XrefRangeEnd = 770898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveKeyframesInFuture(float currentTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &currentTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_RemoveKeyframesInFuture_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770898, XrefRangeEnd = 770899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveKeyframesInPast(float currentTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &currentTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_RemoveKeyframesInPast_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770899, XrefRangeEnd = 770900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetNextKeyTime(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNextKeyTime_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770900, XrefRangeEnd = 770901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Value GetNextValue(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNextValue_Public_Value_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<Value>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770901, XrefRangeEnd = 770903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentKeyframeTime(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_GetCurrentKeyframeTime_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasFuture(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_HasFuture_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770903, XrefRangeEnd = 770904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasNewValue(float prevTime, float currentTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prevTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_HasNewValue_Public_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770904, XrefRangeEnd = 770905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(Curve<Keyframe, Value> timeline)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) timeline);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_CopyFrom_Public_Void_Curve_2_Keyframe_Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770905, XrefRangeEnd = 770906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetKeyframes(
      Il2CppReferenceArray<KeyframeItem<Keyframe>> frames)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frames);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_SetKeyframes_Public_Void_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetKeyframes(IEnumerable<KeyframeItem<Keyframe>> frames)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frames);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr_SetKeyframes_Public_Void_IEnumerable_1_KeyframeItem_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 770921, RefRangeEnd = 770923, XrefRangeStart = 770906, XrefRangeEnd = 770921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Curve()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Curve<Keyframe, Value>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Curve()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", "Curve`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Keyframe>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Value>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr);
      Curve<Keyframe, Value>.NativeFieldInfoPtr__Keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, nameof (_Keyframes));
      Curve<Keyframe, Value>.NativeFieldInfoPtr__InterpolationFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, nameof (_InterpolationFunc));
      Curve<Keyframe, Value>.NativeMethodInfoPtr_Create_Protected_Static_T_Func_4_K_K_Single_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668279);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetValue_Public_Value_Single_CurveWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668280);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_AddKeyframe_Public_Void_Single_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668281);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_InsertKeyframe_Public_Int32_KeyframeItem_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668282);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetKeyframe_Public_KeyframeItem_1_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668283);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetKeyframes_Public_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668284);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNumKeyframes_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668285);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_RemoveKeyframesInFuture_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668286);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_RemoveKeyframesInPast_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668287);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNextKeyTime_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668288);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetNextValue_Public_Value_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668289);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_GetCurrentKeyframeTime_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668290);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_HasFuture_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668291);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_HasNewValue_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668292);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_CopyFrom_Public_Void_Curve_2_Keyframe_Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668293);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_SetKeyframes_Public_Void_Il2CppReferenceArray_1_KeyframeItem_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668294);
      Curve<Keyframe, Value>.NativeMethodInfoPtr_SetKeyframes_Public_Void_IEnumerable_1_KeyframeItem_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668295);
      Curve<Keyframe, Value>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Curve<Keyframe, Value>>.NativeClassPtr, 100668296);
    }

    public Curve(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<KeyframeItem<Keyframe>> _Keyframes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Curve<Keyframe, Value>.NativeFieldInfoPtr__Keyframes));
        return pointer == System.IntPtr.Zero ? (List<KeyframeItem<Keyframe>>) null : new List<KeyframeItem<Keyframe>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Curve<Keyframe, Value>.NativeFieldInfoPtr__Keyframes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<Keyframe, Keyframe, float, Value> _InterpolationFunc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Curve<Keyframe, Value>.NativeFieldInfoPtr__InterpolationFunc));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Keyframe, Keyframe, float, Value>) null : new Il2CppSystem.Func<Keyframe, Keyframe, float, Value>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Curve<Keyframe, Value>.NativeFieldInfoPtr__InterpolationFunc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Create_Protected_Static_T_Func_4_K_K_Single_V_0\u00603<V>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Curve<T, K>.NativeMethodInfoPtr_Create_Protected_Static_T_Func_4_K_K_Single_V_0, Il2CppClassPointerStore<Curve<T, K>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
      }))));
    }
  }
}
