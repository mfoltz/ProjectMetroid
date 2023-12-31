// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStringBuilder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class LocalizedStringBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeyResources;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_LocalizedStringBuilderBase_EntityManager_Entity_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 794593, RefRangeEnd = 794602, XrefRangeStart = 794570, XrefRangeEnd = 794593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedStringBuilderBase Convert(
      EntityManager dstManager,
      Entity entity,
      UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizedStringBuilder.NativeMethodInfoPtr_Convert_Public_LocalizedStringBuilderBase_EntityManager_Entity_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizedStringBuilderBase*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedStringBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizedStringBuilder()
    {
      Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizedStringBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr);
      LocalizedStringBuilder.NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr, nameof (LocalizationKey));
      LocalizedStringBuilder.NativeFieldInfoPtr_KeyResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr, nameof (KeyResources));
      LocalizedStringBuilder.NativeMethodInfoPtr_Convert_Public_LocalizedStringBuilderBase_EntityManager_Entity_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr, 100670066);
      LocalizedStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringBuilder>.NativeClassPtr, 100670067);
    }

    public LocalizedStringBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LocalizationKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilder.NativeFieldInfoPtr_LocalizationKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilder.NativeFieldInfoPtr_LocalizationKey)) = value;
      }
    }

    public unsafe List<LocalizationStringBuilderResource> KeyResources
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilder.NativeFieldInfoPtr_KeyResources));
        return pointer == System.IntPtr.Zero ? (List<LocalizationStringBuilderResource>) null : new List<LocalizationStringBuilderResource>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilder.NativeFieldInfoPtr_KeyResources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
