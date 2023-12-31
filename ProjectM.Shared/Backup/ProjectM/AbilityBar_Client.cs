// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityBar_Client
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityBar_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientCastGroupNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SimulatedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPreviewInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientCastStartedCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandledServerInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSimulating;
    [FieldOffset(0)]
    public NetworkId ClientCastGroupNetworkId;
    [FieldOffset(8)]
    public AbilityBar_Shared SimulatedData;
    [FieldOffset(144)]
    public Entity AimPreviewInstance;
    [FieldOffset(152)]
    public SequenceState CastSequence;
    [FieldOffset(160)]
    public int ClientCastStartedCounter;
    [FieldOffset(164)]
    public int ClientInterruptCounter;
    [FieldOffset(168)]
    public int HandledServerInterruptCounter;
    [FieldOffset(172)]
    public bool IsSimulating;

    static AbilityBar_Client()
    {
      Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityBar_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr);
      AbilityBar_Client.NativeFieldInfoPtr_ClientCastGroupNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (ClientCastGroupNetworkId));
      AbilityBar_Client.NativeFieldInfoPtr_SimulatedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (SimulatedData));
      AbilityBar_Client.NativeFieldInfoPtr_AimPreviewInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (AimPreviewInstance));
      AbilityBar_Client.NativeFieldInfoPtr_CastSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (CastSequence));
      AbilityBar_Client.NativeFieldInfoPtr_ClientCastStartedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (ClientCastStartedCounter));
      AbilityBar_Client.NativeFieldInfoPtr_ClientInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (ClientInterruptCounter));
      AbilityBar_Client.NativeFieldInfoPtr_HandledServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (HandledServerInterruptCounter));
      AbilityBar_Client.NativeFieldInfoPtr_IsSimulating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, nameof (IsSimulating));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBar_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
