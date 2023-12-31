// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayConditionGroupData_Editor_Parent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GameplayConditionGroupData_Editor_Parent : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RootGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubConditionGroups;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748951, XrefRangeEnd = 748960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayConditionGroupData_Editor_Parent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayConditionGroupData_Editor_Parent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayConditionGroupData_Editor_Parent()
    {
      Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayConditionGroupData_Editor_Parent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr);
      GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_RootGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr, nameof (RootGroup));
      GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_SubConditionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr, nameof (SubConditionGroups));
      GameplayConditionGroupData_Editor_Parent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConditionGroupData_Editor_Parent>.NativeClassPtr, 100665945);
    }

    public GameplayConditionGroupData_Editor_Parent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor RootGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_RootGroup));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor) null : new GameplayConditionGroupData_Editor(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_RootGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameplayConditionGroupData_Editor> SubConditionGroups
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_SubConditionGroups));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameplayConditionGroupData_Editor>) null : new Il2CppReferenceArray<GameplayConditionGroupData_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor_Parent.NativeFieldInfoPtr_SubConditionGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
