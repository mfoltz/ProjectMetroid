// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedMapIconData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ManagedMapIconData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalState;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverState;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderLocalizedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeaderLocalizedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowObjectRotation;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedMapIconData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedMapIconData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedMapIconData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedMapIconData()
    {
      Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedMapIconData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr);
      ManagedMapIconData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (PrefabGUID));
      ManagedMapIconData.NativeFieldInfoPtr_VisualOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (VisualOverrides));
      ManagedMapIconData.NativeFieldInfoPtr_NormalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (NormalState));
      ManagedMapIconData.NativeFieldInfoPtr_HoverState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (HoverState));
      ManagedMapIconData.NativeFieldInfoPtr_HeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (HeaderLocalizedKey));
      ManagedMapIconData.NativeFieldInfoPtr_SubHeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (SubHeaderLocalizedKey));
      ManagedMapIconData.NativeFieldInfoPtr_ShowObjectRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, nameof (ShowObjectRotation));
      ManagedMapIconData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, 100664345);
      ManagedMapIconData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedMapIconData>.NativeClassPtr, 100664346);
    }

    public ManagedMapIconData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGUID PrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_PrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_PrefabGUID)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<MapIconStates> VisualOverrides
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_VisualOverrides));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MapIconStates>) null : new Il2CppReferenceArray<MapIconStates>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_VisualOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MapIconState NormalState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_NormalState);
        return new MapIconState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_NormalState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MapIconState HoverState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_HoverState);
        return new MapIconState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_HoverState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey HeaderLocalizedKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_HeaderLocalizedKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_HeaderLocalizedKey)) = value;
      }
    }

    public unsafe LocalizationKey SubHeaderLocalizedKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_SubHeaderLocalizedKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_SubHeaderLocalizedKey)) = value;
      }
    }

    public unsafe bool ShowObjectRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_ShowObjectRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedMapIconData.NativeFieldInfoPtr_ShowObjectRotation)) = value;
      }
    }
  }
}
