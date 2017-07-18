#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("AdventureGrainInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace AdventureGrainInterfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::AdventureGrainInterfaces.IMonsterGrain))]
    internal class OrleansCodeGenMonsterGrainReference : global::Orleans.Runtime.GrainReference, global::AdventureGrainInterfaces.IMonsterGrain
    {
        protected @OrleansCodeGenMonsterGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMonsterGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -376047659;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::AdventureGrainInterfaces.IMonsterGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -376047659;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -376047659:
                    switch (@methodId)
                    {
                        case -67873697:
                            return "Name";
                        case 1642984836:
                            return "SetInfo";
                        case -1091530947:
                            return "SetRoomGrain";
                        case 2108089454:
                            return "RoomGrain";
                        case 122057053:
                            return "Kill";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -376047659 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @Name()
        {
            return base.@InvokeMethodAsync<global::System.String>(-67873697, null);
        }

        public global::System.Threading.Tasks.Task @SetInfo(global::AdventureGrainInterfaces.MonsterInfo @info)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1642984836, new global::System.Object[]{@info});
        }

        public global::System.Threading.Tasks.Task @SetRoomGrain(global::AdventureGrainInterfaces.IRoomGrain @room)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1091530947, new global::System.Object[]{@room is global::Orleans.Grain ? @room.@AsReference<global::AdventureGrainInterfaces.IRoomGrain>() : @room});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.IRoomGrain> @RoomGrain()
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.IRoomGrain>(2108089454, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @Kill(global::AdventureGrainInterfaces.IRoomGrain @room)
        {
            return base.@InvokeMethodAsync<global::System.String>(122057053, new global::System.Object[]{@room is global::Orleans.Grain ? @room.@AsReference<global::AdventureGrainInterfaces.IRoomGrain>() : @room});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::AdventureGrainInterfaces.IMonsterGrain", -376047659, typeof (global::AdventureGrainInterfaces.IMonsterGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMonsterGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -376047659:
                        switch (@methodId)
                        {
                            case -67873697:
                                return ((global::AdventureGrainInterfaces.IMonsterGrain)@grain).@Name().@Box();
                            case 1642984836:
                                return ((global::AdventureGrainInterfaces.IMonsterGrain)@grain).@SetInfo((global::AdventureGrainInterfaces.MonsterInfo)@arguments[0]).@Box();
                            case -1091530947:
                                return ((global::AdventureGrainInterfaces.IMonsterGrain)@grain).@SetRoomGrain((global::AdventureGrainInterfaces.IRoomGrain)@arguments[0]).@Box();
                            case 2108089454:
                                return ((global::AdventureGrainInterfaces.IMonsterGrain)@grain).@RoomGrain().@Box();
                            case 122057053:
                                return ((global::AdventureGrainInterfaces.IMonsterGrain)@grain).@Kill((global::AdventureGrainInterfaces.IRoomGrain)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -376047659 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -376047659;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::AdventureGrainInterfaces.MonsterInfo)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenAdventureGrainInterfaces_MonsterInfoSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::AdventureGrainInterfaces.MonsterInfo input = (global::AdventureGrainInterfaces.MonsterInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@KilledBy, stream, typeof (global::System.Collections.Generic.List<global::System.Int64>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::AdventureGrainInterfaces.MonsterInfo result = new global::AdventureGrainInterfaces.MonsterInfo();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Id = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@KilledBy = (global::System.Collections.Generic.List<global::System.Int64>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Int64>), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::AdventureGrainInterfaces.MonsterInfo)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::AdventureGrainInterfaces.MonsterInfo), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenAdventureGrainInterfaces_MonsterInfoSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::AdventureGrainInterfaces.IPlayerGrain))]
    internal class OrleansCodeGenPlayerGrainReference : global::Orleans.Runtime.GrainReference, global::AdventureGrainInterfaces.IPlayerGrain
    {
        protected @OrleansCodeGenPlayerGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPlayerGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1219399184;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::AdventureGrainInterfaces.IPlayerGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1219399184;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1219399184:
                    switch (@methodId)
                    {
                        case -67873697:
                            return "Name";
                        case 316304768:
                            return "SetName";
                        case -1091530947:
                            return "SetRoomGrain";
                        case 2108089454:
                            return "RoomGrain";
                        case -1632993044:
                            return "Die";
                        case 646042025:
                            return "Play";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1219399184 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @Name()
        {
            return base.@InvokeMethodAsync<global::System.String>(-67873697, null);
        }

        public global::System.Threading.Tasks.Task @SetName(global::System.String @name)
        {
            return base.@InvokeMethodAsync<global::System.Object>(316304768, new global::System.Object[]{@name});
        }

        public global::System.Threading.Tasks.Task @SetRoomGrain(global::AdventureGrainInterfaces.IRoomGrain @room)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1091530947, new global::System.Object[]{@room is global::Orleans.Grain ? @room.@AsReference<global::AdventureGrainInterfaces.IRoomGrain>() : @room});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.IRoomGrain> @RoomGrain()
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.IRoomGrain>(2108089454, null);
        }

        public global::System.Threading.Tasks.Task @Die()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1632993044, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @Play(global::System.String @command)
        {
            return base.@InvokeMethodAsync<global::System.String>(646042025, new global::System.Object[]{@command});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::AdventureGrainInterfaces.IPlayerGrain", -1219399184, typeof (global::AdventureGrainInterfaces.IPlayerGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPlayerGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1219399184:
                        switch (@methodId)
                        {
                            case -67873697:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@Name().@Box();
                            case 316304768:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@SetName((global::System.String)@arguments[0]).@Box();
                            case -1091530947:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@SetRoomGrain((global::AdventureGrainInterfaces.IRoomGrain)@arguments[0]).@Box();
                            case 2108089454:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@RoomGrain().@Box();
                            case -1632993044:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@Die().@Box();
                            case 646042025:
                                return ((global::AdventureGrainInterfaces.IPlayerGrain)@grain).@Play((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1219399184 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1219399184;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::AdventureGrainInterfaces.IRoomGrain))]
    internal class OrleansCodeGenRoomGrainReference : global::Orleans.Runtime.GrainReference, global::AdventureGrainInterfaces.IRoomGrain
    {
        protected @OrleansCodeGenRoomGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRoomGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 543472358;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::AdventureGrainInterfaces.IRoomGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 543472358;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 543472358:
                    switch (@methodId)
                    {
                        case 288293111:
                            return "Description";
                        case -1430615142:
                            return "SetInfo";
                        case -323822931:
                            return "ExitTo";
                        case 2139370243:
                            return "Enter";
                        case 1116324557:
                            return "Exit";
                        case -1993785949:
                            return "Enter";
                        case -328248759:
                            return "Exit";
                        case 1453036231:
                            return "Drop";
                        case 1542534434:
                            return "Take";
                        case -1840220455:
                            return "FindThing";
                        case 22289778:
                            return "FindPlayer";
                        case -649945656:
                            return "FindMonster";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 543472358 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @Description(global::AdventureGrainInterfaces.PlayerInfo @whoisAsking)
        {
            return base.@InvokeMethodAsync<global::System.String>(288293111, new global::System.Object[]{@whoisAsking});
        }

        public global::System.Threading.Tasks.Task @SetInfo(global::AdventureGrainInterfaces.RoomInfo @info)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1430615142, new global::System.Object[]{@info});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.IRoomGrain> @ExitTo(global::System.String @direction)
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.IRoomGrain>(-323822931, new global::System.Object[]{@direction});
        }

        public global::System.Threading.Tasks.Task @Enter(global::AdventureGrainInterfaces.PlayerInfo @player)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2139370243, new global::System.Object[]{@player});
        }

        public global::System.Threading.Tasks.Task @Exit(global::AdventureGrainInterfaces.PlayerInfo @player)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1116324557, new global::System.Object[]{@player});
        }

        public global::System.Threading.Tasks.Task @Enter(global::AdventureGrainInterfaces.MonsterInfo @monster)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1993785949, new global::System.Object[]{@monster});
        }

        public global::System.Threading.Tasks.Task @Exit(global::AdventureGrainInterfaces.MonsterInfo @monster)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-328248759, new global::System.Object[]{@monster});
        }

        public global::System.Threading.Tasks.Task @Drop(global::AdventureGrainInterfaces.Thing @thing)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1453036231, new global::System.Object[]{@thing});
        }

        public global::System.Threading.Tasks.Task @Take(global::AdventureGrainInterfaces.Thing @thing)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1542534434, new global::System.Object[]{@thing});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.Thing> @FindThing(global::System.String @name)
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.Thing>(-1840220455, new global::System.Object[]{@name});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.PlayerInfo> @FindPlayer(global::System.String @name)
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.PlayerInfo>(22289778, new global::System.Object[]{@name});
        }

        public global::System.Threading.Tasks.Task<global::AdventureGrainInterfaces.MonsterInfo> @FindMonster(global::System.String @name)
        {
            return base.@InvokeMethodAsync<global::AdventureGrainInterfaces.MonsterInfo>(-649945656, new global::System.Object[]{@name});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::AdventureGrainInterfaces.IRoomGrain", 543472358, typeof (global::AdventureGrainInterfaces.IRoomGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRoomGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 543472358:
                        switch (@methodId)
                        {
                            case 288293111:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Description((global::AdventureGrainInterfaces.PlayerInfo)@arguments[0]).@Box();
                            case -1430615142:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@SetInfo((global::AdventureGrainInterfaces.RoomInfo)@arguments[0]).@Box();
                            case -323822931:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@ExitTo((global::System.String)@arguments[0]).@Box();
                            case 2139370243:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Enter((global::AdventureGrainInterfaces.PlayerInfo)@arguments[0]).@Box();
                            case 1116324557:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Exit((global::AdventureGrainInterfaces.PlayerInfo)@arguments[0]).@Box();
                            case -1993785949:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Enter((global::AdventureGrainInterfaces.MonsterInfo)@arguments[0]).@Box();
                            case -328248759:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Exit((global::AdventureGrainInterfaces.MonsterInfo)@arguments[0]).@Box();
                            case 1453036231:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Drop((global::AdventureGrainInterfaces.Thing)@arguments[0]).@Box();
                            case 1542534434:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@Take((global::AdventureGrainInterfaces.Thing)@arguments[0]).@Box();
                            case -1840220455:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@FindThing((global::System.String)@arguments[0]).@Box();
                            case 22289778:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@FindPlayer((global::System.String)@arguments[0]).@Box();
                            case -649945656:
                                return ((global::AdventureGrainInterfaces.IRoomGrain)@grain).@FindMonster((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 543472358 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 543472358;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::AdventureGrainInterfaces.PlayerInfo)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenAdventureGrainInterfaces_PlayerInfoSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::AdventureGrainInterfaces.PlayerInfo input = (global::AdventureGrainInterfaces.PlayerInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Key, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::AdventureGrainInterfaces.PlayerInfo result = new global::AdventureGrainInterfaces.PlayerInfo();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Key = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::AdventureGrainInterfaces.PlayerInfo)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::AdventureGrainInterfaces.PlayerInfo), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenAdventureGrainInterfaces_PlayerInfoSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::AdventureGrainInterfaces.RoomInfo)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenAdventureGrainInterfaces_RoomInfoSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::AdventureGrainInterfaces.RoomInfo input = (global::AdventureGrainInterfaces.RoomInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Description, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Directions, stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int64>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::AdventureGrainInterfaces.RoomInfo result = new global::AdventureGrainInterfaces.RoomInfo();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Description = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Directions = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int64>), stream);
            result.@Id = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::AdventureGrainInterfaces.RoomInfo)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::AdventureGrainInterfaces.RoomInfo), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenAdventureGrainInterfaces_RoomInfoSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::AdventureGrainInterfaces.Thing)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenAdventureGrainInterfaces_ThingSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::AdventureGrainInterfaces.Thing input = (global::AdventureGrainInterfaces.Thing)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Category, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Commands, stream, typeof (global::System.Collections.Generic.List<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FoundIn, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::AdventureGrainInterfaces.Thing result = new global::AdventureGrainInterfaces.Thing();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Category = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Commands = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.String>), stream);
            result.@FoundIn = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@Id = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::AdventureGrainInterfaces.Thing)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::AdventureGrainInterfaces.Thing), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenAdventureGrainInterfaces_ThingSerializer()
        {
            Register();
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
