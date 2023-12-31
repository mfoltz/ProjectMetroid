// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffCategoryComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BuffCategoryComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Level;
    private static readonly IntPtr NativeFieldInfoPtr_Groups;
    private static readonly IntPtr NativeFieldInfoPtr_KeepOldest;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724947, XrefRangeEnd = 724950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BuffCategoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffCategoryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffCategoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffCategoryComponent()
    {
      Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffCategoryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr);
      BuffCategoryComponent.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr, nameof (Level));
      BuffCategoryComponent.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr, nameof (Groups));
      BuffCategoryComponent.NativeFieldInfoPtr_KeepOldest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr, nameof (KeepOldest));
      BuffCategoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr, 100664147);
      BuffCategoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffCategoryComponent>.NativeClassPtr, 100664148);
    }

    public BuffCategoryComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Level
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_Level));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_Level)) = value;
      }
    }

    public unsafe long Groups
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_Groups));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_Groups)) = value;
      }
    }

    public unsafe bool KeepOldest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_KeepOldest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffCategoryComponent.NativeFieldInfoPtr_KeepOldest)) = value;
      }
    }
  }
}
