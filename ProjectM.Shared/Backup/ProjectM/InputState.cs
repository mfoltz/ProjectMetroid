// Decompiled with JetBrains decompiler
// Type: ProjectM.InputState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsPressed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPerspectivePositionPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPlayerPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedInputs;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogValues;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Private_Boolean_NativeList_1_InputFlag_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSyncedState_Public_SyncedInputState_0;
    [FieldOffset(0)]
    public ControllerType ControllerType;
    [FieldOffset(8)]
    public NativeList<InputFlag> InputsUp;
    [FieldOffset(24)]
    public NativeList<InputFlag> InputsDown;
    [FieldOffset(40)]
    public NativeList<InputFlag> InputsPressed;
    [FieldOffset(56)]
    public float3 MouseWorldPosition;
    [FieldOffset(68)]
    public float3 MouseWorldPerspectivePositionPlane;
    [FieldOffset(80)]
    public float3 MouseWorldPositionPlayerPlane;
    [FieldOffset(92)]
    public float3 MouseWorldPositionPlayerPlaneTerrainProjection;
    [FieldOffset(104)]
    public float3 MouseWorldPositionFilterByHeightLevel;
    [FieldOffset(116)]
    public InputFlag SyncedInputs;
    [FieldOffset(120)]
    public InputState._AnalogValues_e__FixedBuffer AnalogValues;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 741219, RefRangeEnd = 741222, XrefRangeStart = 741208, XrefRangeEnd = 741219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(NativeList<InputFlag> list, InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &list;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_IsSet_Private_Boolean_NativeList_1_InputFlag_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(64)]
    [CachedScanResults(RefRangeStart = 741223, RefRangeEnd = 741287, XrefRangeStart = 741222, XrefRangeEnd = 741223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputUp(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(114)]
    [CachedScanResults(RefRangeStart = 741288, RefRangeEnd = 741402, XrefRangeStart = 741287, XrefRangeEnd = 741288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputDown(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 741403, RefRangeEnd = 741432, XrefRangeStart = 741402, XrefRangeEnd = 741403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputPressed(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 741433, RefRangeEnd = 741458, XrefRangeStart = 741432, XrefRangeEnd = 741433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAnalogValue(AnalogInput inputType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 741459, RefRangeEnd = 741460, XrefRangeStart = 741458, XrefRangeEnd = 741459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnalogValue(AnalogInput inputType, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 741490, RefRangeEnd = 741491, XrefRangeStart = 741460, XrefRangeEnd = 741490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncedInputState ToSyncedState()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputState.NativeMethodInfoPtr_ToSyncedState_Public_SyncedInputState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedInputState*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InputState()
    {
      Il2CppClassPointerStore<InputState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputState>.NativeClassPtr);
      InputState.NativeFieldInfoPtr_ControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (ControllerType));
      InputState.NativeFieldInfoPtr_InputsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (InputsUp));
      InputState.NativeFieldInfoPtr_InputsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (InputsDown));
      InputState.NativeFieldInfoPtr_InputsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (InputsPressed));
      InputState.NativeFieldInfoPtr_MouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (MouseWorldPosition));
      InputState.NativeFieldInfoPtr_MouseWorldPerspectivePositionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (MouseWorldPerspectivePositionPlane));
      InputState.NativeFieldInfoPtr_MouseWorldPositionPlayerPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (MouseWorldPositionPlayerPlane));
      InputState.NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (MouseWorldPositionPlayerPlaneTerrainProjection));
      InputState.NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (MouseWorldPositionFilterByHeightLevel));
      InputState.NativeFieldInfoPtr_SyncedInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (SyncedInputs));
      InputState.NativeFieldInfoPtr_AnalogValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState>.NativeClassPtr, nameof (AnalogValues));
      InputState.NativeMethodInfoPtr_IsSet_Private_Boolean_NativeList_1_InputFlag_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665427);
      InputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665428);
      InputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665429);
      InputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665430);
      InputState.NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665431);
      InputState.NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665432);
      InputState.NativeMethodInfoPtr_ToSyncedState_Public_SyncedInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100665433);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [ObfuscatedName("ProjectM.InputState/<AnalogValues>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _AnalogValues_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _AnalogValues_e__FixedBuffer()
      {
        Il2CppClassPointerStore<InputState._AnalogValues_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputState>.NativeClassPtr, "<AnalogValues>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputState._AnalogValues_e__FixedBuffer>.NativeClassPtr);
        InputState._AnalogValues_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputState._AnalogValues_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputState._AnalogValues_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
