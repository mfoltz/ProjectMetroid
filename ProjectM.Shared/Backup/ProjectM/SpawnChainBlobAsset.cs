// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainBlobAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnChainBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChainElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainElementIndex;
    [FieldOffset(0)]
    public BlobArray<SpawnChainBlobAsset.ChainElement> ChainElements;
    [FieldOffset(8)]
    public int MainElementIndex;

    static SpawnChainBlobAsset()
    {
      Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr);
      SpawnChainBlobAsset.NativeFieldInfoPtr_ChainElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr, nameof (ChainElements));
      SpawnChainBlobAsset.NativeFieldInfoPtr_MainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr, nameof (MainElementIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChainElement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementTransitions;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UseAutoTransition;
      private static readonly System.IntPtr NativeFieldInfoPtr_AutoTransitionData;
      [FieldOffset(0)]
      public BlobArray<SpawnChainBlobAsset.ChainElementTransition> ElementTransitions;
      [FieldOffset(8)]
      public SpawnChainData.ElementName Name;
      [FieldOffset(40)]
      public int ElementIndex;
      [FieldOffset(44)]
      public PrefabGUID PrefabType;
      [FieldOffset(48)]
      public bool UseAutoTransition;
      [FieldOffset(52)]
      public AutoChainTransitionConstants AutoTransitionData;

      static ChainElement()
      {
        Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr, nameof (ChainElement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr);
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_ElementTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (ElementTransitions));
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (Name));
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_ElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (ElementIndex));
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (PrefabType));
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_UseAutoTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (UseAutoTransition));
        SpawnChainBlobAsset.ChainElement.NativeFieldInfoPtr_AutoTransitionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, nameof (AutoTransitionData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElement>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChainElementTransition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChainElementIndexToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndOfChainTransition;
      [FieldOffset(0)]
      public SpawnChainData.TransitionId TransitionId;
      [FieldOffset(32)]
      public int ChainElementIndexToSpawn;
      [FieldOffset(36)]
      public int Importance;
      [FieldOffset(40)]
      public bool EndOfChainTransition;

      static ChainElementTransition()
      {
        Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainBlobAsset>.NativeClassPtr, nameof (ChainElementTransition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr);
        SpawnChainBlobAsset.ChainElementTransition.NativeFieldInfoPtr_TransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr, nameof (TransitionId));
        SpawnChainBlobAsset.ChainElementTransition.NativeFieldInfoPtr_ChainElementIndexToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr, nameof (ChainElementIndexToSpawn));
        SpawnChainBlobAsset.ChainElementTransition.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr, nameof (Importance));
        SpawnChainBlobAsset.ChainElementTransition.NativeFieldInfoPtr_EndOfChainTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr, nameof (EndOfChainTransition));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainBlobAsset.ChainElementTransition>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
