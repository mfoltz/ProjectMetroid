﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EntityMoveSpeedToBlackboard
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityMoveSpeedToBlackboard
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Register;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public SharedField<Entity> Register;
    [FieldOffset(4)]
    public SharedField<float> OutRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344409, XrefRangeEnd = 1344423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityMoveSpeedToBlackboard.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityMoveSpeedToBlackboard()
    {
      Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EntityMoveSpeedToBlackboard));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr);
      EntityMoveSpeedToBlackboard.NativeFieldInfoPtr_Register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr, nameof (Register));
      EntityMoveSpeedToBlackboard.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr, nameof (OutRegister));
      EntityMoveSpeedToBlackboard.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr, 100665437);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityMoveSpeedToBlackboard>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
