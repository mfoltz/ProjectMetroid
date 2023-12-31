// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncedInputState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SyncedInputState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputsPressed;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogValues;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputUp_Public_Boolean_SyncedInputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputDown_Public_Boolean_SyncedInputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputPressed_Public_Boolean_SyncedInputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0;
    [FieldOffset(0)]
    public SyncedInputFlag InputsUp;
    [FieldOffset(4)]
    public SyncedInputFlag InputsDown;
    [FieldOffset(8)]
    public SyncedInputFlag InputsPressed;
    [FieldOffset(12)]
    public SyncedInputState._AnalogValues_e__FixedBuffer AnalogValues;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 741177, RefRangeEnd = 741178, XrefRangeStart = 741177, XrefRangeEnd = 741177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputUp(SyncedInputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_SyncedInputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741178, XrefRangeEnd = 741179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputUp(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool IsInputDown(SyncedInputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_SyncedInputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741179, XrefRangeEnd = 741180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputDown(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 741180, RefRangeEnd = 741181, XrefRangeStart = 741180, XrefRangeEnd = 741180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputPressed(SyncedInputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_SyncedInputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 741182, RefRangeEnd = 741197, XrefRangeStart = 741181, XrefRangeEnd = 741182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInputPressed(InputFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 741198, RefRangeEnd = 741205, XrefRangeStart = 741197, XrefRangeEnd = 741198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAnalogValue(AnalogInput inputType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 741206, RefRangeEnd = 741208, XrefRangeStart = 741205, XrefRangeEnd = 741206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnalogValue(AnalogInput inputType, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedInputState.NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncedInputState()
    {
      Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SyncedInputState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr);
      SyncedInputState.NativeFieldInfoPtr_InputsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, nameof (InputsUp));
      SyncedInputState.NativeFieldInfoPtr_InputsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, nameof (InputsDown));
      SyncedInputState.NativeFieldInfoPtr_InputsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, nameof (InputsPressed));
      SyncedInputState.NativeFieldInfoPtr_AnalogValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, nameof (AnalogValues));
      SyncedInputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_SyncedInputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665419);
      SyncedInputState.NativeMethodInfoPtr_IsInputUp_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665420);
      SyncedInputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_SyncedInputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665421);
      SyncedInputState.NativeMethodInfoPtr_IsInputDown_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665422);
      SyncedInputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_SyncedInputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665423);
      SyncedInputState.NativeMethodInfoPtr_IsInputPressed_Public_Boolean_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665424);
      SyncedInputState.NativeMethodInfoPtr_GetAnalogValue_Public_Single_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665425);
      SyncedInputState.NativeMethodInfoPtr_SetAnalogValue_Public_Void_AnalogInput_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, 100665426);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [ObfuscatedName("ProjectM.SyncedInputState/<AnalogValues>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _AnalogValues_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _AnalogValues_e__FixedBuffer()
      {
        Il2CppClassPointerStore<SyncedInputState._AnalogValues_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncedInputState>.NativeClassPtr, "<AnalogValues>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedInputState._AnalogValues_e__FixedBuffer>.NativeClassPtr);
        SyncedInputState._AnalogValues_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedInputState._AnalogValues_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncedInputState._AnalogValues_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
