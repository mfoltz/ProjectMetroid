// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedItemData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ManagedItemData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedItemData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedItemData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedItemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedItemData()
    {
      Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedItemData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr);
      ManagedItemData.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, nameof (PrefabName));
      ManagedItemData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, nameof (Icon));
      ManagedItemData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, nameof (Name));
      ManagedItemData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, nameof (Description));
      ManagedItemData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, 100664330);
      ManagedItemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedItemData>.NativeClassPtr, 100664331);
    }

    public ManagedItemData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string PrefabName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_PrefabName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_PrefabName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizedStringBuilderBase Description
    {
      get
      {
        return *(LocalizedStringBuilderBase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizedStringBuilderBase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedItemData.NativeFieldInfoPtr_Description)) = value;
      }
    }
  }
}
