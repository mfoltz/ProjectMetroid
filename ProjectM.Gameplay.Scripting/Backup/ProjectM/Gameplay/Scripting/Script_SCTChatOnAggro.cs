// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SCTChatOnAggro
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_SCTChatOnAggro : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AlertEntries;
    private static readonly IntPtr NativeFieldInfoPtr_AggroEntries;
    private static readonly IntPtr NativeFieldInfoPtr_AggroDroppedEntries;
    private static readonly IntPtr NativeFieldInfoPtr_SCTType;
    private static readonly IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188552, XrefRangeEnd = 1188575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SCTChatOnAggro.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188575, XrefRangeEnd = 1188593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SCTChatOnAggro()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SCTChatOnAggro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SCTChatOnAggro()
    {
      Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SCTChatOnAggro));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr);
      Script_SCTChatOnAggro.NativeFieldInfoPtr_AlertEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (AlertEntries));
      Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (AggroEntries));
      Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroDroppedEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (AggroDroppedEntries));
      Script_SCTChatOnAggro.NativeFieldInfoPtr_SCTType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (SCTType));
      Script_SCTChatOnAggro.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (Cooldown));
      Script_SCTChatOnAggro.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, 100664763);
      Script_SCTChatOnAggro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, 100664764);
    }

    public Script_SCTChatOnAggro(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<SCTChatOnAggro_Entry> AlertEntries
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AlertEntries));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<SCTChatOnAggro_Entry>) null : new Il2CppStructArray<SCTChatOnAggro_Entry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AlertEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<SCTChatOnAggro_Entry> AggroEntries
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroEntries));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<SCTChatOnAggro_Entry>) null : new Il2CppStructArray<SCTChatOnAggro_Entry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<SCTChatOnAggro_Entry> AggroDroppedEntries
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroDroppedEntries));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<SCTChatOnAggro_Entry>) null : new Il2CppStructArray<SCTChatOnAggro_Entry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_AggroDroppedEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type SCTType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_SCTType));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_SCTType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Cooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_Cooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SCTChatOnAggro.NativeFieldInfoPtr_Cooldown)) = value;
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SCTChatOnAggro.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SCTChatOnAggro.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_SCTChatOnAggro.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SCTChatOnAggro>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SCTChatOnAggro.Client>.NativeClassPtr);
        Script_SCTChatOnAggro.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SCTChatOnAggro.Client>.NativeClassPtr, 100664765);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
