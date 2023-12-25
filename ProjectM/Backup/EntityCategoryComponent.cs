// Decompiled with JetBrains decompiler
// Type: EntityCategoryComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class EntityCategoryComponent : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_MainCategory;
  private static readonly IntPtr NativeFieldInfoPtr_UnitCategory;
  private static readonly IntPtr NativeFieldInfoPtr_ResourceLevel;
  private static readonly IntPtr NativeFieldInfoPtr_StructureCategory;
  private static readonly IntPtr NativeFieldInfoPtr_MaterialCategory;
  private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914073, XrefRangeEnd = 914076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    Entity entity,
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &entity;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EntityCategoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EntityCategoryComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EntityCategoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static EntityCategoryComponent()
  {
    Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (EntityCategoryComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr);
    EntityCategoryComponent.NativeFieldInfoPtr_MainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, nameof (MainCategory));
    EntityCategoryComponent.NativeFieldInfoPtr_UnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, nameof (UnitCategory));
    EntityCategoryComponent.NativeFieldInfoPtr_ResourceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, nameof (ResourceLevel));
    EntityCategoryComponent.NativeFieldInfoPtr_StructureCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, nameof (StructureCategory));
    EntityCategoryComponent.NativeFieldInfoPtr_MaterialCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, nameof (MaterialCategory));
    EntityCategoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, 100663511);
    EntityCategoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCategoryComponent>.NativeClassPtr, 100663512);
  }

  public EntityCategoryComponent(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe MainEntityCategory MainCategory
  {
    get
    {
      return *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_MainCategory));
    }
    [param: In] set
    {
      *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_MainCategory)) = value;
    }
  }

  public unsafe UnitCategory UnitCategory
  {
    get
    {
      return *(UnitCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_UnitCategory));
    }
    [param: In] set
    {
      *(UnitCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_UnitCategory)) = value;
    }
  }

  public unsafe int ResourceLevel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_ResourceLevel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_ResourceLevel)) = value;
    }
  }

  public unsafe StructureCategory StructureCategory
  {
    get
    {
      return *(StructureCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_StructureCategory));
    }
    [param: In] set
    {
      *(StructureCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_StructureCategory)) = value;
    }
  }

  public unsafe MaterialCategory MaterialCategory
  {
    get
    {
      return *(MaterialCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_MaterialCategory));
    }
    [param: In] set
    {
      *(MaterialCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityCategoryComponent.NativeFieldInfoPtr_MaterialCategory)) = value;
    }
  }
}
