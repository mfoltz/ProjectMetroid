// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.InputCommandBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputCommandBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INPUT_COMMANDS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalClientFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceCast;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeReplay_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeAim_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeReplay_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeAim_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public CommandMovementInput MovementInput;
    [FieldOffset(12)]
    public CommandRotationInput RotationInput;
    [FieldOffset(44)]
    public EntityInput RawInput;
    [FieldOffset(176)]
    public int ClientFrame;
    [FieldOffset(180)]
    public int OriginalClientFrame;
    [FieldOffset(184)]
    public int ServerFrame;
    [FieldOffset(192)]
    public double EndTime;
    [FieldOffset(200)]
    public float DeltaTime;
    [FieldOffset(204)]
    public float TimeSinceCast;

    public unsafe double StartTime
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 785493, RefRangeEnd = 785497, XrefRangeStart = 785493, XrefRangeEnd = 785493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_get_StartTime_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785515, RefRangeEnd = 785516, XrefRangeStart = 785497, XrefRangeEnd = 785515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeReplay(
      ref NetBufferOut netBufferOut,
      [In] ref InputCommandBufferElement command)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferOut;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_SerializeReplay_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785554, RefRangeEnd = 785556, XrefRangeStart = 785516, XrefRangeEnd = 785554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      ref NetBufferOut netBuffer,
      [In] ref InputCommandBufferElement command)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785572, RefRangeEnd = 785573, XrefRangeStart = 785556, XrefRangeEnd = 785572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeAim(
      ref NetBufferOut netBuffer,
      [In] ref InputCommandBufferElement lastCommand)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_SerializeAim_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785590, RefRangeEnd = 785591, XrefRangeStart = 785573, XrefRangeEnd = 785590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeserializeReplay(
      ref NetBufferIn netBuffer,
      ref InputCommandBufferElement command)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_DeserializeReplay_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785621, RefRangeEnd = 785623, XrefRangeStart = 785591, XrefRangeEnd = 785621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Deserialize(
      ref NetBufferIn netBuffer,
      ref InputCommandBufferElement command)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785638, RefRangeEnd = 785639, XrefRangeStart = 785623, XrefRangeEnd = 785638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeserializeAim(
      ref NetBufferIn netBuffer,
      ref InputCommandBufferElement command)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_DeserializeAim_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785639, XrefRangeEnd = 785668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(InputCommandBufferElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static InputCommandBufferElement()
    {
      Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (InputCommandBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr);
      InputCommandBufferElement.NativeFieldInfoPtr_MAX_INPUT_COMMANDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (MAX_INPUT_COMMANDS));
      InputCommandBufferElement.NativeFieldInfoPtr_MovementInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (MovementInput));
      InputCommandBufferElement.NativeFieldInfoPtr_RotationInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (RotationInput));
      InputCommandBufferElement.NativeFieldInfoPtr_RawInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (RawInput));
      InputCommandBufferElement.NativeFieldInfoPtr_ClientFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (ClientFrame));
      InputCommandBufferElement.NativeFieldInfoPtr_OriginalClientFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (OriginalClientFrame));
      InputCommandBufferElement.NativeFieldInfoPtr_ServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (ServerFrame));
      InputCommandBufferElement.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (EndTime));
      InputCommandBufferElement.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (DeltaTime));
      InputCommandBufferElement.NativeFieldInfoPtr_TimeSinceCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, nameof (TimeSinceCast));
      InputCommandBufferElement.NativeMethodInfoPtr_get_StartTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669235);
      InputCommandBufferElement.NativeMethodInfoPtr_SerializeReplay_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669236);
      InputCommandBufferElement.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669237);
      InputCommandBufferElement.NativeMethodInfoPtr_SerializeAim_Public_Static_Void_byref_NetBufferOut_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669238);
      InputCommandBufferElement.NativeMethodInfoPtr_DeserializeReplay_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669239);
      InputCommandBufferElement.NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669240);
      InputCommandBufferElement.NativeMethodInfoPtr_DeserializeAim_Public_Static_Void_byref_NetBufferIn_byref_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669241);
      InputCommandBufferElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, 100669242);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputCommandBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_INPUT_COMMANDS
    {
      get
      {
        int maxInputCommands;
        IL2CPP.il2cpp_field_static_get_value(InputCommandBufferElement.NativeFieldInfoPtr_MAX_INPUT_COMMANDS, (void*) &maxInputCommands);
        return maxInputCommands;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputCommandBufferElement.NativeFieldInfoPtr_MAX_INPUT_COMMANDS, (void*) &value);
      }
    }
  }
}
