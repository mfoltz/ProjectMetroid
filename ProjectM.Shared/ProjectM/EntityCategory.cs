// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityCategory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityCategory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_StructureCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSame_Public_Boolean_EntityCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSameMaterial_Public_Boolean_EntityCategory_0;
    [FieldOffset(0)]
    public MainEntityCategory MainCategory;
    [FieldOffset(1)]
    public UnitCategory UnitCategory;
    [FieldOffset(2)]
    public StructureCategory StructureCategory;
    [FieldOffset(3)]
    public MaterialCategory MaterialCategory;
    [FieldOffset(4)]
    public int ResourceLevel;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737282, RefRangeEnd = 737285, XrefRangeStart = 737282, XrefRangeEnd = 737282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSame(EntityCategory other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityCategory.NativeMethodInfoPtr_IsSame_Public_Boolean_EntityCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737285, RefRangeEnd = 737286, XrefRangeStart = 737285, XrefRangeEnd = 737285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSameMaterial(EntityCategory other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityCategory.NativeMethodInfoPtr_IsSameMaterial_Public_Boolean_EntityCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityCategory()
    {
      Il2CppClassPointerStore<EntityCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityCategory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr);
      EntityCategory.NativeFieldInfoPtr_MainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, nameof (MainCategory));
      EntityCategory.NativeFieldInfoPtr_UnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, nameof (UnitCategory));
      EntityCategory.NativeFieldInfoPtr_StructureCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, nameof (StructureCategory));
      EntityCategory.NativeFieldInfoPtr_MaterialCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, nameof (MaterialCategory));
      EntityCategory.NativeFieldInfoPtr_ResourceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, nameof (ResourceLevel));
      EntityCategory.NativeMethodInfoPtr_IsSame_Public_Boolean_EntityCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, 100665129);
      EntityCategory.NativeMethodInfoPtr_IsSameMaterial_Public_Boolean_EntityCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, 100665130);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityCategory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
