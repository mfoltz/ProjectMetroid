// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag : 
    ContainerPropertyBag<SpawnUIPrefabOnLoad>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291816, XrefRangeEnd = 1291829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "Unity.Properties.Generated", nameof (ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag));
      ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag>.NativeClassPtr, 100669957);
    }

    public ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ReferencePrefab_Property : Property<SpawnUIPrefabOnLoad, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_SpawnUIPrefabOnLoad_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SpawnUIPrefabOnLoad_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291809, XrefRangeEnd = 1291811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1291814, RefRangeEnd = 1291816, XrefRangeStart = 1291811, XrefRangeEnd = 1291814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ReferencePrefab_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref SpawnUIPrefabOnLoad container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_SpawnUIPrefabOnLoad_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SpawnUIPrefabOnLoad local = ref container;
        IntPtr pointer1 = ptr;
        SpawnUIPrefabOnLoad spawnUiPrefabOnLoad = pointer1 == IntPtr.Zero ? (SpawnUIPrefabOnLoad) null : new SpawnUIPrefabOnLoad(pointer1);
        local = spawnUiPrefabOnLoad;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref SpawnUIPrefabOnLoad container, GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SpawnUIPrefabOnLoad_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SpawnUIPrefabOnLoad local = ref container;
        IntPtr pointer = ptr;
        SpawnUIPrefabOnLoad spawnUiPrefabOnLoad = pointer == IntPtr.Zero ? (SpawnUIPrefabOnLoad) null : new SpawnUIPrefabOnLoad(pointer);
        local = spawnUiPrefabOnLoad;
      }

      static ReferencePrefab_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag>.NativeClassPtr, nameof (ReferencePrefab_Property));
        ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr, 100669958);
        ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr, 100669959);
        ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr, 100669960);
        ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_SpawnUIPrefabOnLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr, 100669961);
        ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SpawnUIPrefabOnLoad_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_SpawnUIPrefabOnLoad_PropertyBag.ReferencePrefab_Property>.NativeClassPtr, 100669962);
      }

      public ReferencePrefab_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
