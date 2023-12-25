// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TryFindServantRoamPath
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TryFindServantRoamPath
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RANGE;
    private static readonly System.IntPtr NativeFieldInfoPtr_POS_OFFSET_MAGNITUDE;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutPathRequestEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousCastleFloorEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindValidCastleFloorEntities_Private_NativeArray_1_Entity_Entity_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidAndSameCastle_Private_Boolean_Entity_Entity_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public SharedField<float3> OutPosition;
    [FieldOffset(4)]
    public SharedField<Entity> OutPathRequestEntityRegister;
    [FieldOffset(8)]
    public PrivateField<Entity> PreviousCastleFloorEntity;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345937, RefRangeEnd = 1345938, XrefRangeStart = 1345898, XrefRangeEnd = 1345937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryFindServantRoamPath.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345938, XrefRangeEnd = 1345940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryFindServantRoamPath.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345940, XrefRangeEnd = 1345941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TryFindServantRoamPath.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345978, RefRangeEnd = 1345979, XrefRangeStart = 1345941, XrefRangeEnd = 1345978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<Entity> FindValidCastleFloorEntities(
      Entity coffinCastleHeartEntity,
      bool allowFloorChange,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &coffinCastleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowFloorChange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryFindServantRoamPath.NativeMethodInfoPtr_FindValidCastleFloorEntities_Private_NativeArray_1_Entity_Entity_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345988, RefRangeEnd = 1345989, XrefRangeStart = 1345979, XrefRangeEnd = 1345988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidAndSameCastle(
      Entity castleFloorEntity,
      Entity coffinCastleHeartEntity,
      [In] ref BehaviourTreeExpansionContext context,
      [In] ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &castleFloorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &coffinCastleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryFindServantRoamPath.NativeMethodInfoPtr_IsValidAndSameCastle_Private_Boolean_Entity_Entity_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TryFindServantRoamPath()
    {
      Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TryFindServantRoamPath));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr);
      TryFindServantRoamPath.NativeFieldInfoPtr_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, nameof (RANGE));
      TryFindServantRoamPath.NativeFieldInfoPtr_POS_OFFSET_MAGNITUDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, nameof (POS_OFFSET_MAGNITUDE));
      TryFindServantRoamPath.NativeFieldInfoPtr_OutPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, nameof (OutPosition));
      TryFindServantRoamPath.NativeFieldInfoPtr_OutPathRequestEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, nameof (OutPathRequestEntityRegister));
      TryFindServantRoamPath.NativeFieldInfoPtr_PreviousCastleFloorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, nameof (PreviousCastleFloorEntity));
      TryFindServantRoamPath.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, 100665570);
      TryFindServantRoamPath.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, 100665571);
      TryFindServantRoamPath.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, 100665572);
      TryFindServantRoamPath.NativeMethodInfoPtr_FindValidCastleFloorEntities_Private_NativeArray_1_Entity_Entity_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, 100665573);
      TryFindServantRoamPath.NativeMethodInfoPtr_IsValidAndSameCastle_Private_Boolean_Entity_Entity_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, 100665574);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TryFindServantRoamPath>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int RANGE
    {
      get
      {
        int range;
        IL2CPP.il2cpp_field_static_get_value(TryFindServantRoamPath.NativeFieldInfoPtr_RANGE, (void*) &range);
        return range;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TryFindServantRoamPath.NativeFieldInfoPtr_RANGE, (void*) &value);
      }
    }

    public static unsafe float POS_OFFSET_MAGNITUDE
    {
      get
      {
        float posOffsetMagnitude;
        IL2CPP.il2cpp_field_static_get_value(TryFindServantRoamPath.NativeFieldInfoPtr_POS_OFFSET_MAGNITUDE, (void*) &posOffsetMagnitude);
        return posOffsetMagnitude;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TryFindServantRoamPath.NativeFieldInfoPtr_POS_OFFSET_MAGNITUDE, (void*) &value);
      }
    }
  }
}
