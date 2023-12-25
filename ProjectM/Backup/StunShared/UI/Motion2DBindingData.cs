// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DBindingData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public class Motion2DBindingData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timeline;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Motion2DBindingData_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922735, XrefRangeEnd = 922758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DBindingData Create(UnityEngine.Object owner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DBindingData.NativeMethodInfoPtr_Create_Public_Static_Motion2DBindingData_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Motion2DBindingData) null : new Motion2DBindingData(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DBindingData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DBindingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DBindingData()
    {
      Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DBindingData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr);
      Motion2DBindingData.NativeFieldInfoPtr_GameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, nameof (GameObjects));
      Motion2DBindingData.NativeFieldInfoPtr_ComponentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, nameof (ComponentData));
      Motion2DBindingData.NativeFieldInfoPtr_Timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, nameof (Timeline));
      Motion2DBindingData.NativeFieldInfoPtr_Bindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, nameof (Bindings));
      Motion2DBindingData.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, nameof (Owner));
      Motion2DBindingData.NativeMethodInfoPtr_Create_Public_Static_Motion2DBindingData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, 100663820);
      Motion2DBindingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBindingData>.NativeClassPtr, 100663821);
    }

    public Motion2DBindingData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<GameObject> GameObjects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_GameObjects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_GameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Motion2DComponentData> ComponentData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_ComponentData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Motion2DComponentData>) null : new Il2CppReferenceArray<Motion2DComponentData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_ComponentData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DTimeline Timeline
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Timeline));
        return pointer == System.IntPtr.Zero ? (Motion2DTimeline) null : new Motion2DTimeline(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Timeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Motion2DTimelineBinding> Bindings
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Bindings));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Motion2DTimelineBinding>) null : new Il2CppReferenceArray<Motion2DTimelineBinding>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Bindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.Object Owner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Owner));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBindingData.NativeFieldInfoPtr_Owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
