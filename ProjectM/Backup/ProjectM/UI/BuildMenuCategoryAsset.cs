// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuCategoryAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class BuildMenuCategoryAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tags;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousTag;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousTag_Public_get_Tag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PreviousTag_Public_set_Void_Tag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe BuildMenuCategoryAsset.Tag PreviousTag
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuCategoryAsset.NativeMethodInfoPtr_get_PreviousTag_Public_get_Tag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuildMenuCategoryAsset.Tag) null : new BuildMenuCategoryAsset.Tag(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuCategoryAsset.NativeMethodInfoPtr_set_PreviousTag_Public_set_Void_Tag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenuCategoryAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuCategoryAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenuCategoryAsset()
    {
      Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (BuildMenuCategoryAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr);
      BuildMenuCategoryAsset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, nameof (Name));
      BuildMenuCategoryAsset.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, nameof (Icon));
      BuildMenuCategoryAsset.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, nameof (Tags));
      BuildMenuCategoryAsset.NativeFieldInfoPtr__PreviousTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, nameof (_PreviousTag));
      BuildMenuCategoryAsset.NativeMethodInfoPtr_get_PreviousTag_Public_get_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, 100692257);
      BuildMenuCategoryAsset.NativeMethodInfoPtr_set_PreviousTag_Public_set_Void_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, 100692258);
      BuildMenuCategoryAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, 100692259);
    }

    public BuildMenuCategoryAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<BuildMenuCategoryAsset.Tag> Tags
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Tags));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BuildMenuCategoryAsset.Tag>) null : new Il2CppReferenceArray<BuildMenuCategoryAsset.Tag>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenuCategoryAsset.Tag _PreviousTag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr__PreviousTag));
        return pointer == System.IntPtr.Zero ? (BuildMenuCategoryAsset.Tag) null : new BuildMenuCategoryAsset.Tag(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.NativeFieldInfoPtr__PreviousTag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class Tag : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TagAsset;
      private static readonly System.IntPtr NativeFieldInfoPtr_Structures;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Tag()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuCategoryAsset.Tag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Tag()
      {
        Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuCategoryAsset>.NativeClassPtr, nameof (Tag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr);
        BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_TagAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr, nameof (TagAsset));
        BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_Structures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr, nameof (Structures));
        BuildMenuCategoryAsset.Tag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuCategoryAsset.Tag>.NativeClassPtr, 100692260);
      }

      public Tag(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BuildMenuTagAsset TagAsset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_TagAsset));
          return pointer == System.IntPtr.Zero ? (BuildMenuTagAsset) null : new BuildMenuTagAsset(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_TagAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<UnityEngine.Object> Structures
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_Structures));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UnityEngine.Object>) null : new Il2CppReferenceArray<UnityEngine.Object>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuCategoryAsset.Tag.NativeFieldInfoPtr_Structures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
