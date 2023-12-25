// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptions
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
  public struct EvaluateCastOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutTargetEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutAbilityIndexRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutCooldownRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public PrefabGUID CastOptionsPrefab;
    [FieldOffset(4)]
    public PrivateField<Entity> RequestEntityRegister;
    [FieldOffset(8)]
    public SharedField<Entity> OutTargetEntityRegister;
    [FieldOffset(12)]
    public SharedField<int> OutAbilityIndexRegister;
    [FieldOffset(16)]
    public SharedField<bool> OutInterruptOnTargetDeathRegister;
    [FieldOffset(20)]
    public SharedField<float> OutCooldownRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344449, XrefRangeEnd = 1344481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptions.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344481, XrefRangeEnd = 1344496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptions.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344496, XrefRangeEnd = 1344512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptions.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EvaluateCastOptions()
    {
      Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr);
      EvaluateCastOptions.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (CastOptionsPrefab));
      EvaluateCastOptions.NativeFieldInfoPtr_RequestEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (RequestEntityRegister));
      EvaluateCastOptions.NativeFieldInfoPtr_OutTargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (OutTargetEntityRegister));
      EvaluateCastOptions.NativeFieldInfoPtr_OutAbilityIndexRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (OutAbilityIndexRegister));
      EvaluateCastOptions.NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (OutInterruptOnTargetDeathRegister));
      EvaluateCastOptions.NativeFieldInfoPtr_OutCooldownRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, nameof (OutCooldownRegister));
      EvaluateCastOptions.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, 100665440);
      EvaluateCastOptions.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, 100665441);
      EvaluateCastOptions.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, 100665442);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
