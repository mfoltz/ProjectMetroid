// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_idjfhgckc
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_idjfhgckc
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_OverrideColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_OverrideLocalizedText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_SourceObjectType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessage_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ScrollingCombatTextMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ScrollingCombatTextMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ScrollingCombatTextMessage;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float ScrollingCombatTextMessage_BloodQuality;
    [FieldOffset(12)]
    public float3 ScrollingCombatTextMessage_OverrideColor;
    [FieldOffset(24)]
    public Il2CppSystem.Guid ScrollingCombatTextMessage_OverrideLocalizedText;
    [FieldOffset(40)]
    public float3 ScrollingCombatTextMessage_Position;
    [FieldOffset(52)]
    public NetworkId ScrollingCombatTextMessage_Source;
    [FieldOffset(60)]
    public PrefabGUID ScrollingCombatTextMessage_SourceObjectType;
    [FieldOffset(64)]
    public NetworkId ScrollingCombatTextMessage_Target;
    [FieldOffset(72)]
    public PrefabGUID ScrollingCombatTextMessage_Type;
    [FieldOffset(76)]
    public float ScrollingCombatTextMessage_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1588202, XrefRangeEnd = 1588296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_idjfhgckc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1588337, RefRangeEnd = 1588338, XrefRangeStart = 1588296, XrefRangeEnd = 1588337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_idjfhgckc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_idjfhgckc()
    {
      Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_idjfhgckc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr);
      Snapshot_idjfhgckc.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_BloodQuality));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_OverrideColor));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_OverrideLocalizedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_OverrideLocalizedText));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_Position));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_Source));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_SourceObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_SourceObjectType));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_Target));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_Type));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ScrollingCombatTextMessage_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ScrollingCombatTextMessage_Value));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedFields_ScrollingCombatTextMessage_Start));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedFields_ScrollingCombatTextMessage_Count));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_Position));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_Source));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_Target));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_Type));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (FrameChangedIndex_ScrollingCombatTextMessage_Value));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataStartOffset_ScrollingCombatTextMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ComponentDataStartOffset_ScrollingCombatTextMessage));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataSize_ScrollingCombatTextMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (ComponentDataSize_ScrollingCombatTextMessage));
      Snapshot_idjfhgckc.NativeFieldInfoPtr_CompBit_ScrollingCombatTextMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, nameof (CompBit_ScrollingCombatTextMessage));
      Snapshot_idjfhgckc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, 100664710);
      Snapshot_idjfhgckc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, 100664711);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_idjfhgckc>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ScrollingCombatTextMessage_Start
    {
      get
      {
        int textMessageStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Start, (void*) &textMessageStart);
        return textMessageStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ScrollingCombatTextMessage_Count
    {
      get
      {
        int textMessageCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Count, (void*) &textMessageCount);
        return textMessageCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedFields_ScrollingCombatTextMessage_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage
    {
      get
      {
        int combatTextMessage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage, (void*) &combatTextMessage);
        return combatTextMessage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality
    {
      get
      {
        int messageBloodQuality;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality, (void*) &messageBloodQuality);
        return messageBloodQuality;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_BloodQuality, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor
    {
      get
      {
        int messageOverrideColor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor, (void*) &messageOverrideColor);
        return messageOverrideColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideColor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText
    {
      get
      {
        int overrideLocalizedText;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText, (void*) &overrideLocalizedText);
        return overrideLocalizedText;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_OverrideLocalizedText, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_Position
    {
      get
      {
        int textMessagePosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Position, (void*) &textMessagePosition);
        return textMessagePosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Position, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_Source
    {
      get
      {
        int textMessageSource;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Source, (void*) &textMessageSource);
        return textMessageSource;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Source, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType
    {
      get
      {
        int sourceObjectType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType, (void*) &sourceObjectType);
        return sourceObjectType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_SourceObjectType, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_Target
    {
      get
      {
        int textMessageTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Target, (void*) &textMessageTarget);
        return textMessageTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_Type
    {
      get
      {
        int combatTextMessageType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Type, (void*) &combatTextMessageType);
        return combatTextMessageType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Type, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ScrollingCombatTextMessage_Value
    {
      get
      {
        int textMessageValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Value, (void*) &textMessageValue);
        return textMessageValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_FrameChangedIndex_ScrollingCombatTextMessage_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ScrollingCombatTextMessage
    {
      get
      {
        int combatTextMessage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataStartOffset_ScrollingCombatTextMessage, (void*) &combatTextMessage);
        return combatTextMessage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataStartOffset_ScrollingCombatTextMessage, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ScrollingCombatTextMessage
    {
      get
      {
        int combatTextMessage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataSize_ScrollingCombatTextMessage, (void*) &combatTextMessage);
        return combatTextMessage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_ComponentDataSize_ScrollingCombatTextMessage, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ScrollingCombatTextMessage
    {
      get
      {
        ulong combatTextMessage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_CompBit_ScrollingCombatTextMessage, (void*) &combatTextMessage);
        return combatTextMessage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_idjfhgckc.NativeFieldInfoPtr_CompBit_ScrollingCombatTextMessage, (void*) &value);
      }
    }
  }
}
