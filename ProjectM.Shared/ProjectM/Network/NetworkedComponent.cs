// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkedComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_SyncTo;
    private static readonly IntPtr NativeFieldInfoPtr_AlwaysNetworked;
    private static readonly IntPtr NativeFieldInfoPtr_DisableWhenNoPlayersInRange;
    private static readonly IntPtr NativeFieldInfoPtr_TimeoutAfter;
    private static readonly IntPtr NativeFieldInfoPtr_BasePriority;
    private static readonly IntPtr NativeFieldInfoPtr_SyncRate;
    private static readonly IntPtr NativeMethodInfoPtr_GetSynced_Public_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 784915, RefRangeEnd = 784916, XrefRangeStart = 784914, XrefRangeEnd = 784915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncedCollection GetSynced()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedComponent.NativeMethodInfoPtr_GetSynced_Public_SyncedCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SyncedCollection) null : new SyncedCollection(pointer);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784916, XrefRangeEnd = 784984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784984, XrefRangeEnd = 784985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkedComponent()
    {
      Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkedComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr);
      NetworkedComponent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (Type));
      NetworkedComponent.NativeFieldInfoPtr_SyncTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (SyncTo));
      NetworkedComponent.NativeFieldInfoPtr_AlwaysNetworked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (AlwaysNetworked));
      NetworkedComponent.NativeFieldInfoPtr_DisableWhenNoPlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (DisableWhenNoPlayersInRange));
      NetworkedComponent.NativeFieldInfoPtr_TimeoutAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (TimeoutAfter));
      NetworkedComponent.NativeFieldInfoPtr_BasePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (BasePriority));
      NetworkedComponent.NativeFieldInfoPtr_SyncRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, nameof (SyncRate));
      NetworkedComponent.NativeMethodInfoPtr_GetSynced_Public_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, 100669162);
      NetworkedComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, 100669163);
      NetworkedComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, 100669164);
      NetworkedComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponent>.NativeClassPtr, 100669165);
    }

    public NetworkedComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkedTypeEnum Type
    {
      get
      {
        return *(NetworkedTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(NetworkedTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe SyncToEnum SyncTo
    {
      get
      {
        return *(SyncToEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_SyncTo));
      }
      [param: In] set
      {
        *(SyncToEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_SyncTo)) = value;
      }
    }

    public unsafe bool AlwaysNetworked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_AlwaysNetworked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_AlwaysNetworked)) = value;
      }
    }

    public unsafe bool DisableWhenNoPlayersInRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_DisableWhenNoPlayersInRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_DisableWhenNoPlayersInRange)) = value;
      }
    }

    public unsafe float TimeoutAfter
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_TimeoutAfter));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_TimeoutAfter)) = value;
      }
    }

    public unsafe float BasePriority
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_BasePriority));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_BasePriority)) = value;
      }
    }

    public unsafe float SyncRate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_SyncRate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponent.NativeFieldInfoPtr_SyncRate)) = value;
      }
    }
  }
}
