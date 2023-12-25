// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningConsumer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningConsumer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplacePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplacePrefabIgnoreCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlterPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetConsumerAsOwner;
    [FieldOffset(0)]
    public bool ReplacePrefab;
    [FieldOffset(4)]
    public PrefabGUID Prefab;
    [FieldOffset(8)]
    public float Radius;
    [FieldOffset(12)]
    public bool ReplacePrefabIgnoreCollision;
    [FieldOffset(13)]
    public bool AlterPosition;
    [FieldOffset(14)]
    public bool SetConsumerAsOwner;

    static LightningConsumer()
    {
      Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningConsumer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr);
      LightningConsumer.NativeFieldInfoPtr_ReplacePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (ReplacePrefab));
      LightningConsumer.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (Prefab));
      LightningConsumer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (Radius));
      LightningConsumer.NativeFieldInfoPtr_ReplacePrefabIgnoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (ReplacePrefabIgnoreCollision));
      LightningConsumer.NativeFieldInfoPtr_AlterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (AlterPosition));
      LightningConsumer.NativeFieldInfoPtr_SetConsumerAsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, nameof (SetConsumerAsOwner));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningConsumer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
