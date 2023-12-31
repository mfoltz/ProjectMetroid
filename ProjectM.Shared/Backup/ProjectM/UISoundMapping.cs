// Decompiled with JetBrains decompiler
// Type: ProjectM.UISoundMapping
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UISoundMapping : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sounds;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFmodEvent_Public_Boolean_UISoundType_byref_FmodEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFmodEvent_Public_FmodEvent_UISoundType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 762847, RefRangeEnd = 762850, XrefRangeStart = 762845, XrefRangeEnd = 762847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetFmodEvent(UISoundType type, out FmodEvent fmodEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &type;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISoundMapping.NativeMethodInfoPtr_TryGetFmodEvent_Public_Boolean_UISoundType_byref_FmodEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref FmodEvent local = ref fmodEvent;
      System.IntPtr pointer = zero;
      FmodEvent fmodEvent1 = pointer == System.IntPtr.Zero ? (FmodEvent) null : new FmodEvent(pointer);
      local = fmodEvent1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762850, XrefRangeEnd = 762851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FmodEvent GetFmodEvent(UISoundType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UISoundMapping.NativeMethodInfoPtr_GetFmodEvent_Public_FmodEvent_UISoundType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new FmodEvent(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762851, XrefRangeEnd = 762860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UISoundMapping()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UISoundMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UISoundMapping()
    {
      Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UISoundMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr);
      UISoundMapping.NativeFieldInfoPtr_Sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr, nameof (Sounds));
      UISoundMapping.NativeMethodInfoPtr_TryGetFmodEvent_Public_Boolean_UISoundType_byref_FmodEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr, 100667398);
      UISoundMapping.NativeMethodInfoPtr_GetFmodEvent_Public_FmodEvent_UISoundType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr, 100667399);
      UISoundMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr, 100667400);
    }

    public UISoundMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<UISoundMapping.UISound> Sounds
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.NativeFieldInfoPtr_Sounds));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UISoundMapping.UISound>) null : new Il2CppReferenceArray<UISoundMapping.UISound>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.NativeFieldInfoPtr_Sounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class UISound : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_FmodEvent;

      static UISound()
      {
        Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISoundMapping>.NativeClassPtr, nameof (UISound));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr);
        UISoundMapping.UISound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr, nameof (Type));
        UISoundMapping.UISound.NativeFieldInfoPtr_FmodEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr, nameof (FmodEvent));
      }

      public UISound(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UISound()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UISoundMapping.UISound>.NativeClassPtr, data));
      }

      public unsafe UISoundType Type
      {
        get
        {
          return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.UISound.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.UISound.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public FmodEvent FmodEvent
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.UISound.NativeFieldInfoPtr_FmodEvent);
          return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISoundMapping.UISound.NativeFieldInfoPtr_FmodEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
