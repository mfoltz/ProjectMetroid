// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_ReplaceAbilityOnSlotWhenMountedBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class Script_ReplaceAbilityOnSlotWhenMountedBuff : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Replacements;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066873, XrefRangeEnd = 1066884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ReplaceAbilityOnSlotWhenMountedBuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ReplaceAbilityOnSlotWhenMountedBuff()
    {
      Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Script_ReplaceAbilityOnSlotWhenMountedBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr);
      Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeFieldInfoPtr_Replacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr, nameof (Replacements));
      Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr, 100683905);
      Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr, 100683906);
    }

    public Script_ReplaceAbilityOnSlotWhenMountedBuff(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor> Replacements
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeFieldInfoPtr_Replacements));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>) null : new Il2CppReferenceArray<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.NativeFieldInfoPtr_Replacements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class ReplaceAbilityOnSlotWhenMountedBuffElement_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlotIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ReplaceAbilityOnSlotWhenMountedBuffElement_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ReplaceAbilityOnSlotWhenMountedBuffElement_Editor()
      {
        Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff>.NativeClassPtr, nameof (ReplaceAbilityOnSlotWhenMountedBuffElement_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr);
        Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilityGroupGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr, nameof (AbilityGroupGuid));
        Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilitySlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr, nameof (AbilitySlotIndex));
        Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr, nameof (Priority));
        Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor>.NativeClassPtr, 100683907);
      }

      public ReplaceAbilityOnSlotWhenMountedBuffElement_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabGuidComponent AbilityGroupGuid
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilityGroupGuid));
          return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilityGroupGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int AbilitySlotIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilitySlotIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_AbilitySlotIndex)) = value;
        }
      }

      public unsafe int Priority
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_Priority));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ReplaceAbilityOnSlotWhenMountedBuff.ReplaceAbilityOnSlotWhenMountedBuffElement_Editor.NativeFieldInfoPtr_Priority)) = value;
        }
      }
    }
  }
}
