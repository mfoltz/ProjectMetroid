// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveBuffCategoryOnGameplayEventEntry_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class RemoveBuffCategoryOnGameplayEventEntry_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistanceAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategoryFlag;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveBuffCategoryOnGameplayEventEntry_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveBuffCategoryOnGameplayEventEntry_Editor()
    {
      Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RemoveBuffCategoryOnGameplayEventEntry_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr);
      RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_ResistanceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr, nameof (ResistanceAsset));
      RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_BuffCategoryFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr, nameof (BuffCategoryFlag));
      RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffCategoryOnGameplayEventEntry_Editor>.NativeClassPtr, 100678330);
    }

    public RemoveBuffCategoryOnGameplayEventEntry_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuffResistanceAsset ResistanceAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_ResistanceAsset));
        return pointer == System.IntPtr.Zero ? (BuffResistanceAsset) null : new BuffResistanceAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_ResistanceAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe long BuffCategoryFlag
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_BuffCategoryFlag));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffCategoryOnGameplayEventEntry_Editor.NativeFieldInfoPtr_BuffCategoryFlag)) = value;
      }
    }
  }
}
