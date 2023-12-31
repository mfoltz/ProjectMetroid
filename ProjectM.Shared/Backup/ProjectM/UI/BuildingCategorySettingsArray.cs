// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildingCategorySettingsArray
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class BuildingCategorySettingsArray : ReorderableArray<BuildingCategorySettings>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795792, XrefRangeEnd = 795795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildingCategorySettingsArray()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingCategorySettingsArray>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildingCategorySettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildingCategorySettingsArray()
    {
      Il2CppClassPointerStore<BuildingCategorySettingsArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (BuildingCategorySettingsArray));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingCategorySettingsArray>.NativeClassPtr);
      BuildingCategorySettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingCategorySettingsArray>.NativeClassPtr, 100670228);
    }

    public BuildingCategorySettingsArray(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
