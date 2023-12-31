// Decompiled with JetBrains decompiler
// Type: ProjectM.BlockInputState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BlockInputState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockedKeyInputs;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockedAnalogInputs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockKey_Public_Void_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockKeys_Public_Void_Il2CppStructArray_1_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllowKey_Public_Void_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockAnalog_Public_Void_AnalogInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllowAnalog_Public_Void_AnalogInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockAllKeys_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockAllAnalog_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<InputFlag> BlockedKeyInputs;
    [FieldOffset(16)]
    public AnalogInput BlockedAnalogInputs;
    [FieldOffset(20)]
    public ControllerType ControllerType;
    [FieldOffset(24)]
    public float3 MouseWorldPositionFilterByHeightLevel;

    [CallerCount(40)]
    [CachedScanResults(RefRangeStart = 740907, RefRangeEnd = 740947, XrefRangeStart = 740904, XrefRangeEnd = 740907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockKey(InputFlag input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_BlockKey_Public_Void_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(31)]
    [CachedScanResults(RefRangeStart = 740951, RefRangeEnd = 740982, XrefRangeStart = 740947, XrefRangeEnd = 740951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockKeys(Il2CppStructArray<InputFlag> inputs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_BlockKeys_Public_Void_Il2CppStructArray_1_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(30)]
    [CachedScanResults(RefRangeStart = 740991, RefRangeEnd = 741021, XrefRangeStart = 740982, XrefRangeEnd = 740991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AllowKey(InputFlag input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_AllowKey_Public_Void_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 741021, RefRangeEnd = 741124, XrefRangeStart = 741021, XrefRangeEnd = 741021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockAnalog(AnalogInput flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_BlockAnalog_Public_Void_AnalogInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 741124, RefRangeEnd = 741130, XrefRangeStart = 741124, XrefRangeEnd = 741124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AllowAnalog(AnalogInput flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_AllowAnalog_Public_Void_AnalogInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 741138, RefRangeEnd = 741158, XrefRangeStart = 741130, XrefRangeEnd = 741138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockAllKeys()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_BlockAllKeys_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 741158, RefRangeEnd = 741177, XrefRangeStart = 741158, XrefRangeEnd = 741158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockAllAnalog()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlockInputState.NativeMethodInfoPtr_BlockAllAnalog_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlockInputState()
    {
      Il2CppClassPointerStore<BlockInputState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BlockInputState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr);
      BlockInputState.NativeFieldInfoPtr_BlockedKeyInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, nameof (BlockedKeyInputs));
      BlockInputState.NativeFieldInfoPtr_BlockedAnalogInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, nameof (BlockedAnalogInputs));
      BlockInputState.NativeFieldInfoPtr_ControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, nameof (ControllerType));
      BlockInputState.NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, nameof (MouseWorldPositionFilterByHeightLevel));
      BlockInputState.NativeMethodInfoPtr_BlockKey_Public_Void_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665412);
      BlockInputState.NativeMethodInfoPtr_BlockKeys_Public_Void_Il2CppStructArray_1_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665413);
      BlockInputState.NativeMethodInfoPtr_AllowKey_Public_Void_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665414);
      BlockInputState.NativeMethodInfoPtr_BlockAnalog_Public_Void_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665415);
      BlockInputState.NativeMethodInfoPtr_AllowAnalog_Public_Void_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665416);
      BlockInputState.NativeMethodInfoPtr_BlockAllKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665417);
      BlockInputState.NativeMethodInfoPtr_BlockAllAnalog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, 100665418);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlockInputState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
