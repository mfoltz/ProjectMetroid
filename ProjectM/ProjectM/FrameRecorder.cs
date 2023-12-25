// Decompiled with JetBrains decompiler
// Type: ProjectM.FrameRecorder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class FrameRecorder : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnFrameRecorded;
    private static readonly System.IntPtr NativeFieldInfoPtr_Resolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordEveryFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnforceRgb24;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAdd_Public_Static_FrameRecorder_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecordFrameInternal_Private_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecordThisFrame_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1078000, RefRangeEnd = 1078002, XrefRangeStart = 1077990, XrefRangeEnd = 1078000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FrameRecorder GetOrAdd(GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrameRecorder.NativeMethodInfoPtr_GetOrAdd_Public_Static_FrameRecorder_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (FrameRecorder) null : new FrameRecorder(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078002, XrefRangeEnd = 1078007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator RecordFrameInternal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrameRecorder.NativeMethodInfoPtr_RecordFrameInternal_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078007, XrefRangeEnd = 1078013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrameRecorder.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078020, RefRangeEnd = 1078021, XrefRangeStart = 1078013, XrefRangeEnd = 1078020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RecordThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrameRecorder.NativeMethodInfoPtr_RecordThisFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FrameRecorder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrameRecorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FrameRecorder()
    {
      Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FrameRecorder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr);
      FrameRecorder.NativeFieldInfoPtr_OnFrameRecorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, nameof (OnFrameRecorded));
      FrameRecorder.NativeFieldInfoPtr_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, nameof (Resolution));
      FrameRecorder.NativeFieldInfoPtr_RecordEveryFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, nameof (RecordEveryFrame));
      FrameRecorder.NativeFieldInfoPtr_EnforceRgb24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, nameof (EnforceRgb24));
      FrameRecorder.NativeMethodInfoPtr_GetOrAdd_Public_Static_FrameRecorder_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, 100684895);
      FrameRecorder.NativeMethodInfoPtr_RecordFrameInternal_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, 100684896);
      FrameRecorder.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, 100684897);
      FrameRecorder.NativeMethodInfoPtr_RecordThisFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, 100684898);
      FrameRecorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, 100684899);
    }

    public FrameRecorder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<Texture2D> OnFrameRecorded
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_OnFrameRecorded));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Texture2D>) null : new Il2CppSystem.Action<Texture2D>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_OnFrameRecorded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Resolution Resolution
    {
      get
      {
        return *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_Resolution));
      }
      [param: In] set
      {
        *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_Resolution)) = value;
      }
    }

    public unsafe bool RecordEveryFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_RecordEveryFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_RecordEveryFrame)) = value;
      }
    }

    public unsafe bool EnforceRgb24
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_EnforceRgb24));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder.NativeFieldInfoPtr_EnforceRgb24)) = value;
      }
    }

    [ObfuscatedName("ProjectM.FrameRecorder/<RecordFrameInternal>d__5")]
    public sealed class _RecordFrameInternal_d__5 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(77)]
      [CachedScanResults(RefRangeStart = 23421, RefRangeEnd = 23498, XrefRangeStart = 23421, XrefRangeEnd = 23498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _RecordFrameInternal_d__5(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077977, XrefRangeEnd = 1077985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077985, XrefRangeEnd = 1077990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _RecordFrameInternal_d__5()
      {
        Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrameRecorder>.NativeClassPtr, "<RecordFrameInternal>d__5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr);
        FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, "<>1__state");
        FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, "<>2__current");
        FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, "<>4__this");
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684900);
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684901);
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684902);
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684903);
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684904);
        FrameRecorder._RecordFrameInternal_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRecorder._RecordFrameInternal_d__5>.NativeClassPtr, 100684905);
      }

      public _RecordFrameInternal_d__5(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe FrameRecorder __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (FrameRecorder) null : new FrameRecorder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrameRecorder._RecordFrameInternal_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
